﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWallet.View
{
    public partial class OperationListElement : UserControl
    {

        public OperationListElement(string title, string description, string user, float value, DateTime date, Color color) : this()
        {
            label_Title.Text = $"{title} [{value}]";
            label_Description.Text = description;
            label_Date.Text = date.ToShortDateString();
            label_User.Text = user;
            panel_Color.BackColor = color;
        }
        public OperationListElement()
        {
            InitializeComponent();

            foreach (Control item in Controls)
            {
                SetEv(item);
            }
        }

        private void SetEv(Control cntrl)
        {
            foreach (Control item in cntrl.Controls)
            {
                item.MouseLeave += panel1_MouseLeave;
                item.MouseEnter += panel1_MouseEnter;
                item.DoubleClick += EditTransaction;
                SetEv(item);
            }
        }

        private void EditTransaction(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0x22, 0x22, 0x22);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }
    }
}
