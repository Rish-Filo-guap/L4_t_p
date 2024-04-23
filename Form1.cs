using System.Drawing.Imaging;

namespace L4_t_p
{
    public partial class Form1 : Form
    {
        Graphics tree;
        int[] arr;
        int[] levels;
        BTree a;
        Pen pen;
        int scale = 40;
        int delitel = 2;
        public Form1()
        {
            InitializeComponent();
            tree = CreateGraphics();
            InitTree();
        }

        public void marktree(int left, int right, BTree parent, int level)
        {
            if (left == right)
            {
                levels[left] = level;
                return;
            }
            int midle = (left + right) / 2;
            levels[midle] = level;
            parent.AddChild(new BTree(arr[(left + midle - 1) / 2]));
            parent.AddChild(new BTree(arr[(midle + 1 + right) / 2]));
            marktree(left, midle - 1, parent.left, level + 1);
            marktree(midle + 1, right, parent.right, level + 1);
        }
        public void InitTree()
        {
            arr = [10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52];
            levels = new int[arr.Length];
            a = new BTree(arr[arr.Length / 2]);
            marktree(0, arr.Length - 1, a, 0);


        }
        public void DrawTree(Point precoord, BTree bTree, int range)
        {
            pen = new Pen(Color.Black, 3);
            tree.DrawEllipse(pen, precoord.X, precoord.Y, 30, 30);
            bTree.coords = precoord;
            tree.DrawString(bTree.value.ToString(), new Font(DefaultFont, FontStyle.Bold), new SolidBrush(Color.Black), precoord.X + 5, precoord.Y + 5);
            precoord.X += range / delitel;
            precoord.Y += 1 * scale;
            if (bTree.right != null)
            {

                tree.DrawLine(pen, precoord.X - range / delitel + 15, precoord.Y - 1 * scale + 30, precoord.X + 15, precoord.Y);
                DrawTree(precoord, bTree.right, range / delitel);
            }
            precoord.X -= range / (delitel / 2);
            if (bTree.left != null)
            {
                tree.DrawLine(pen, precoord.X + range / delitel + 15, precoord.Y - 1 * scale + 30, precoord.X + 15, precoord.Y);
                DrawTree(precoord, bTree.left, range / delitel);
            }
        }




        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawTree(new Point(Width / 2 - 50, 100), a, Width / 2 - 200);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, 3);
            var result = a.Find((int)SearchNUD.Value);
            if (result != null)
            {
                label1.Text = result.value.ToString();
                tree.DrawEllipse(pen,result.coords.X-5, result.coords.Y-5, 40, 40);
            }
        }
    }
}
