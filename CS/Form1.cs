using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (xpCollection1.Count == 0) {
                Random r = new Random();
                for (int i = 0; i < 10; i++) {
                    MyObject b = new MyObject();
                    b.BLOCKCODE = r.Next(10000).ToString();
                    if (i % 2 != 0)
                        b.FORMERLYWAS = xpCollection1[r.Next(xpCollection1.Count)] as MyObject;
                    b.Save();
                    xpCollection1.Add(b);
                }
            }
            dataGridView1.DataSource = xpCollection1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XPCollection<MyObject> c = new XPCollection<MyObject>(CriteriaOperator.Parse("not RelatedObjects[].Exists()"), null);
            dataGridView2.DataSource = c;
        }
    }

    public class MyObject : XPBaseObject { 
        //PSCID,PSCNAME,BLOCKCODE,FORMERLYWAS from PSCBLOCK
        [Key(true)]
        public int PSCID;
        
        [Association("ID_FORMERLYWAS")]
        public MyObject FORMERLYWAS;

        [Association("ID_FORMERLYWAS", typeof(MyObject))]
        public XPCollection<MyObject> RelatedObjects {
            get { return GetCollection<MyObject>("RelatedObjects"); }
        }
        public string PSCNAME;
        public string BLOCKCODE;

    }
}
