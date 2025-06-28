using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample {
    internal class DataStructures {
        class Node {
            public int key;
            public Node leftNode;
            public Node rightNode;

            public Node(int key) {
                this.key = key;
            }
        }

        Node root;

        public DataStructures() {
            root = null;
        }

        void InsertKey(int key) {
            root = InsertRec(root, key);
        }

        Node InsertRec(Node root, int key) {
            if (root == null)
                return new Node(key);
            if (root.key > key)
                root.leftNode = InsertRec(root.leftNode, key);
            else
                root.rightNode = InsertRec(root.rightNode, key);
            return root;
        }

        void Traverse() {
            Traverse(root);
        }

        void Traverse(Node root) {
            if (root != null) {
                Traverse(root.leftNode);
                Console.WriteLine(root.key);
                Traverse(root.rightNode);
            }
        }
    }
}
