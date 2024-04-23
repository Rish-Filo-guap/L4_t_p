using System.Drawing.Imaging;

namespace L4_t_p
{
    public partial class Form1 : Form
    {
        Graphics tree;
        BTree a;
        Pen pen;
        int scale = 40;
        int glub = 5;
        int delitel = 2;
        public Form1()
        {
            InitializeComponent();
            tree = CreateGraphics();
            //InitTree();

        }
        public void InitTree()
        {
            a = new BTree(1);
            BTree b = new BTree(3);
            BTree c = new BTree(2);
            BTree d = new BTree(4);
            BTree e = new BTree(0);
            a.AddChild(b);
            a.AddChild(c);
            c.AddChild(d);
            c.AddChild(new BTree(5));
            b.AddChild(new BTree(6));
            b.AddChild(new BTree(7));
            d.AddChild(new BTree(8));
            d.AddChild(e);
            e.AddChild(new BTree(2));
            e.AddChild(new BTree(1));







        }
        public void DrawTree(Point precoord, BTree bTree, int range)
        {
            pen = new Pen(Color.Black, 3);
            tree.DrawEllipse(pen, precoord.X, precoord.Y, 30, 30);
            tree.DrawString(bTree.value.ToString(), new Font(DefaultFont, FontStyle.Bold), new SolidBrush(Color.Black),precoord.X+5,precoord.Y);
            //tree.DrawEllipse(pen, 40, 40, 20, 20);
            precoord.X += range/delitel;
            precoord.Y += 1*scale;
            if (bTree.right != null)
            {

                tree.DrawLine(pen, precoord.X - range / delitel+15, precoord.Y-1*scale+30, precoord.X+15, precoord.Y);
                DrawTree(precoord, bTree.right, range/delitel);
            }
            precoord.X -= range/(delitel/2);
            if (bTree.left != null)
            {
                tree.DrawLine(pen, precoord.X+range / delitel+15, precoord.Y-1*scale+30, precoord.X+15 , precoord.Y);
                DrawTree(precoord, bTree.left, range/delitel);
            }
            glub -= 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitTree();
            DrawTree(new Point(Width/2-100, 100), a, Width/2-200);
        }
    }
}
