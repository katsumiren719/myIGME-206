using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

namespace BTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string exeFile = Application.ExecutablePath;
            exeFile = exeFile.Substring(exeFile.LastIndexOf('\\') + 1);

            try
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
        @"Software\WOW6432Node\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
        true))
                {
                    key.SetValue(exeFile, 11001, Microsoft.Win32.RegistryValueKind.DWord);
                    key.Close();
                }
            }
            catch
            {
                MessageBox.Show(@"Cannot access the registry, but the program may work.  If not, run " + exeFile + @" as Administrator or ensure registry setting Computer\HKEY_LOCAL_MACHINE\ SOFTWARE\WOW6432Node\Microsoft\ Internet Explorer\Main\ FeatureControl\FEATURE_BROWSER_EMULATION has a DWORD value for Name = " + exeFile + " with a value of 11001.  Otherwise the Web Browser features may not work.");
            }

            InitializeComponent();

            // give the BTree class objects access to Form1
            BTree.form1 = this;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Butto10Click(object sender, EventArgs e)
        {
            // Exercise #1
            //  insert the following numbers into a binary tree in the following order: 1, 5, 15, 20, 21, 22, 23, 24, 25, 30, 35, 37, 40, 55, 60

            this.richTextBox1.Clear();

            BTree node = null;
            BTree root = null;

            int[] nodes = { 1, 5, 15, 20, 21, 22, 23, 24, 25, 30, 35, 37, 40, 55, 60 };    // add them into the tree in order
            node = new BTree(nodes[0], root);
            root = node;
           
            for (int i = 1; i < nodes.Length; i++)
            {
                node = new BTree(nodes[i], root);
            }

            this.richTextBox1.Text += "\n";

            BTree.TraverseAscending(root);     // traverse in ascending order

            List<int> nodelist = new List<int>(nodes);

            BTree newroot = null;
            int mid = nodes.Length / 2;

            node = new BTree(nodelist[mid], newroot);

            Balancedtree(mid, mid);

            void Balancedtree(int x1, int x2)
            {
                node = new BTree(nodelist[x1], newroot);
                if (newroot == null)
                {
                    newroot = node;
                }
                if (x2 / 2 > 0)
                {
                    Balancedtree((x1 - x2 + x1 - 1) / 2, x2 / 2);
                    Balancedtree((x1 + x2 + x1 + 1) / 2, x2 / 2);
                }
                else
                {
                    node = new BTree(nodelist[x1 - 1], newroot);
                    node = new BTree(nodelist[x1 + 1], newroot);
                }
            }


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(newroot);
        }
    }
   

/// 
///  Our Binary Tree Class
/// 
public class BTree
    {
        //////////////////////////////////////////////////////////
        ///  The most important 3 fields of any Binary Search Tree
        
        // the "less than" branch off of this node
        public BTree ltChild;

        // the "greater than or equal to" branch off of this node
        public BTree gteChild;

        // the data contained in this node
        public object data;
        //////////////////////////////////////////////////////////


        // a boolean to indicate if this is actual data or seed data to prime the tree
        public bool isData;

        // internal counter which is needed by the visualizer
        public int id;

        // access to Form1 to write to the RichTextBox
        public static Form1 form1;

        // keep track of last counter to set this.id
        private static int nLastCntr;


        //////////////////////////////////////////////////////////
        // overload all operators to compare BTree nodes by int or string data
        public static bool operator ==(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data == (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = ((string)a.data == (string)b.data);
                }
            }
            catch
            {
                returnVal = (a == (object)b);
            }

            return (returnVal);
        }

        public static bool operator !=(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data != (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = ((string)a.data != (string)b.data);
                }
            }
            catch
            {
                returnVal = (a != (object)b);
            }

            return (returnVal);
        }

        public static bool operator <(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data < (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) < 0);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator >(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data > (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) > 0);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator >=(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data >= (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) >= 0);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator <=(BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data <= (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) <= 0);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }
        //////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////
        // The constructor which will add the new node to an existing tree
        // if a non-null root is passed in
        // isData defaults to true, but can be set to false if seed data is being added to prime the tree
        public BTree(object nData, BTree root, bool isData = true)
        {
            this.ltChild = null;
            this.gteChild = null;
            this.data = nData;
            this.isData = isData;

            // set internal id which is used by the visualizer
            this.id = nLastCntr;
            ++nLastCntr;

            form1.richTextBox1.Text += nData.ToString() + " ";

            // if a tree exists to add this node to
            if (root != null)
            {
                AddChildNode(this, root);
            }
        }
        //////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////
        /// Recursive AddChildNode method adds BTree nodes to an existing tree
        public static void AddChildNode(BTree newNode, BTree treeNode)
        {
                       
                // if the new node >= the tree node (use the operator overrides)
                if (newNode >= treeNode)
                {
                    // if there is not a child node greater than this tree node (ie. gteChild == null)
                    if (treeNode.gteChild == null)
                    {
                        // set this node's "greater than or equal to" child to this new node
                        treeNode.gteChild = newNode;
                    }
                    else
                    {
                        // otherwise recursively add the new node to the "greater than or equal to" branch
                        AddChildNode(newNode, treeNode.gteChild);
                    }
                }
                else
                {
                    // the new node < this tree node
                    // if there is not a child node less than this tree node (ie. ltChild == null)
                    if (treeNode.ltChild == null)
                    {
                        // set this node's "less than" child to this new node
                        treeNode.ltChild = newNode;
                    }
                    else
                    {
                        // otherwise recursively add the new node to the "less than" branch
                        AddChildNode(newNode, treeNode.ltChild);
                    }
                }
            
        }
        //////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////
        // Delete a node from a tree or branch
        public static BTree DeleteNode(BTree nodeToDelete, BTree treeNode)
        {
            // base case: we reached the end of the branch
            if (treeNode == null)
            {
                return treeNode;
            }

            // traverse the tree to find the target node
            if (nodeToDelete < treeNode)
            {
                treeNode.ltChild = DeleteNode(nodeToDelete, treeNode.ltChild);
            }
            else if (nodeToDelete > treeNode)
            {
                treeNode.gteChild = DeleteNode(nodeToDelete, treeNode.gteChild);
            }
            else
            {
                // this is the node to be deleted  

                // case #1: treeNode has no children
                // case #2: treeNode has one child
                // set treeNode to it's non-null child (if there is one)
                if (treeNode.ltChild == null)
                {
                    return treeNode.gteChild;
                }
                else if (treeNode.gteChild == null)
                {
                    return treeNode.ltChild;
                }

                // case #3: treeNode has two children
                // Get the in-order successor (smallest value  
                // in the "greater than or equal to" branch)  

                // step to the next greater value
                BTree nextValNode = treeNode.gteChild;

                // while not at the end of the branch
                while (nextValNode != null)
                {
                    // replace this "deleted" node with the next sequential data value
                    treeNode.data = nextValNode.data;

                    // walk to next lower value
                    nextValNode = nextValNode.ltChild;
                }

                // delete the in-order successor (which was copied to the "deleted" node)
                nodeToDelete.data = treeNode.data;
                DeleteNode(nodeToDelete, treeNode.gteChild);
            }

            return treeNode;
        }


        //////////////////////////////////////////////////////////
        // Print the tree in ascending order
        public static void TraverseAscending(BTree node)
        {
            if (node != null)
            {
                // handle "less than" children
                TraverseAscending(node.ltChild);

                if (node.isData)
                {
                    // handle current node
                    form1.richTextBox1.Text += " " + node.data.ToString();
                }

                // handle "greater than or equal to children"
                TraverseAscending(node.gteChild);
            }
        }


        //////////////////////////////////////////////////////////
        // Print the tree in descending order
        public static void TraverseDescending(BTree node)
        {
            // base case is node == null
            if (node != null)
            {
            }
        }
    }
}
