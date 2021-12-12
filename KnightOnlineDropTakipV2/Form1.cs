using KnightOnlineDropTakipV2.Data;
using KnightOnlineDropTakipV2.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace KnightOnlineDropTakipV2
{
    public partial class Form1 : Form
    {
        public Drop drop;

        public Form1()
        {
            drop = new Drop();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetDrops();
        }

        private void Clear()
        {
            dropNameTbox.Clear();
            partyMembersTbox.Clear();
            priceNud.Value = 0;
        }
        private void SetParams()
        {
            drop.Name = dropNameTbox.Text;
            drop.Price = priceNud.Value;
            drop.Date = dateTimePicker1.Value;
            drop.PartyMembers = partyMembersTbox.Text;
            drop.IsShared = isSharedTrue.Checked;
                        
        }
        private void AddDrop()
        {
            using (var db = new DataContext())
            {
                db.Drops.Add(drop);
                db.SaveChanges();
                GetDrops();
                Clear();
                drop = new Drop();
                MessageBox.Show("Drop Eklendi.");

            }
        }
        private void UpDateDrop()
        {
            using (var db = new DataContext())
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    drop = (Drop)dataGridView.SelectedRows[0].DataBoundItem;

                    db.Drops.Update(drop);
                    db.SaveChanges();
                    GetDrops();
                    Clear();
                    drop = new Drop();
                    MessageBox.Show("Drop güncellendi.");
                }
            }
        }

        private void RemoveDrop(Drop drop)
        {
            DialogResult result = MessageBox.Show("Drop'u silmek istiyor musunuz?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var db = new DataContext())
                {
                    db.Drops.Remove(drop);
                    db.SaveChanges();
                    GetDrops();
                    MessageBox.Show("Drop silindi.");
                }
            }

        }
        private void GetDrops()
        {
            using (var db = new DataContext())
            {
                var drops = db.Drops.ToList();
                dataGridView.DataSource = drops;
            }
        }
        private void Getir()
        {

            if (dataGridView.SelectedRows.Count > 0)
            {
                drop = (Drop)dataGridView.SelectedRows[0].DataBoundItem;
                priceNud.Value = drop.Price;
                dropNameTbox.Text = drop.Name;
                dateTimePicker1.Value = drop.Date;
                partyMembersTbox.Text = drop.PartyMembers;
            }



        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", @"http://www.nttgameonline.com/knight/tr/ranking/clan/5/Elmo");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SetParams();
            AddDrop();
            GetDrops();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SetParams();
            for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
            {
                var item = (Drop)dataGridView.SelectedRows[i].DataBoundItem;
                RemoveDrop(item);
            }
            GetDrops();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            SetParams();
            UpDateDrop();
            GetDrops();
            Clear();

        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
           Clear();
        }
        private void dataGridView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Getir();
        }
   
    }
}