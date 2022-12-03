using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;

namespace Peminjaman_Buku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(441, 369);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btcek_Click(object sender, EventArgs e)
        {
            if ((tbID.Text).All(Char.IsLetter))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Format ID Salah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbID.Text) != "")
            {
                if ((tbNama.Text) != "")
                {
                    if ((tbNoHP.Text).All(Char.IsLetter))
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Format Nomor HP Salah!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if ((tbNoHP.Text) != "")
                    {
                        if (rbMale.Checked || rbFem.Checked)
                        {
                            if (cb7plus.Checked || cb12plus.Checked || cb16plus.Checked)
                            {
                                if ((rtbAlamat.Text) != "")
                                {
                                    MessageBox.Show("Data Sudah Lengkap, Lanjut dengan memilih Buku!", "Peringatan"
                                        , MessageBoxButtons.OK);
                                    this.Size = new Size(441, 560);
                                }
                                else
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("Alamat harus di isi!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                SystemSounds.Asterisk.Play();
                                MessageBox.Show("Umur harus dipilih!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Kelamin harus dipilih!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("No HP Harus Di isi!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Nama Harus Di isi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {SystemSounds.Asterisk.Play();
                MessageBox.Show("ID Harus Di isi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if ((tbID.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(tbID, "Betul");
                epAttention.SetError(tbID, "");
            }
            else
            {
                epAttention.SetError(tbID, "Input Hanya Boleh Angka");
                epCorrect.SetError(tbID, "");
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if ((tbNama.Text).All(Char.IsNumber))
            {
                epAttention.SetError(tbNama, "Input Hanya Boleh Huruf");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                epCorrect.SetError(tbNama, "Betul");
                epAttention.SetError(tbNama, "");
            }
        }

        private void rtbAlamat_TextChanged(object sender, EventArgs e)
        {

        }
        string kelamin;
        string umur;

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
                kelamin = "Laki-Laki";
                rbFem.Checked = false;
            }
        }

        private void rbFem_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFem.Checked)
            {
                kelamin = "Perempuan";
                rbMale.Checked = false;
            }
        }

        private void rb7plus_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rb12plus_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rb16plus_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if ((tbID.Text).All(Char.IsLetter))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Format ID Salah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tbID.Text) != "")
            {

                if ((tbNama.Text) != "")
                {
                    if ((tbNoHP.Text).All(Char.IsLetter))
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Format Nomor HP Salah!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
  
                    }
                    else if ((tbNoHP.Text) != "")
                    {
                        if (rbMale.Checked || rbFem.Checked)
                        {
                            if (cb7plus.Checked || cb12plus.Checked || cb16plus.Checked)
                            {
                                if ((rtbAlamat.Text) != "")
                                {
                                    if ((cobBuku.Text) != "")
                                    {
                                        if ((tbBookName.Text) != "")
                                        {
                                            if ((dtPinjam.Text) != "")
                                            {
                                                if ((dtKembali.Text) != "")
                                                {
                                                    MessageBox.Show("\nPengisian Sukses Berikut adalah Data yang telah di isi:" +
                                                     "\nID : " + tbID.Text
                                                     + "\nNama : " + tbNama.Text
                                                     + "\nKelamin : " + kelamin
                                                     + "\nUmur : " + umur
                                                     + "\nAlamat : " + rtbAlamat.Text
                                                     + "\nJenis Buku : " + cobBuku.Text
                                                     + "\nNama Buku : " + tbBookName.Text
                                                     + "\nTanggal Peminjaman : " + dtPinjam.Text
                                                     + "\nTanggal Pengembalian : " + dtKembali.Text
                                                     , "Peringatan", MessageBoxButtons.OK);
                                                }
                                                else
                                                {
                                                    SystemSounds.Asterisk.Play();
                                                    MessageBox.Show("Tanggal Pengembalian harus di isi!", "Peringatan",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                SystemSounds.Asterisk.Play();
                                                MessageBox.Show("Tanggal Pinjam harus Di isi!", "Peringatan",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            SystemSounds.Asterisk.Play();
                                            MessageBox.Show("Nama Buku Harus Di isi!", "Peringatan",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        SystemSounds.Asterisk.Play();
                                        MessageBox.Show("Jenis Buku harus di pilih!", "Peringatan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("Alamat harus di isi!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                SystemSounds.Asterisk.Play();
                                MessageBox.Show("Umur harus dipilih!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Kelamin harus dipilih!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("No HP Harus Di isi!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Nama Harus Di isi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }  
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("ID Harus Di isi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb7plus_CheckedChanged(object sender, EventArgs e)
        {
            if (cb7plus.Checked)
            {
                cb12plus.Checked = false;
                cb16plus.Checked = false;
                umur = "7+";
            }
        }

        private void cb12plus_CheckedChanged(object sender, EventArgs e)
        {
            if (cb12plus.Checked)
            {
            cb7plus.Checked = false;
            cb16plus.Checked = false;
            umur = "12+";
            }
        }

        private void cb16plus_CheckedChanged(object sender, EventArgs e)
        {
            if (cb16plus.Checked)
            {
                cb7plus.Checked = false;
                cb12plus.Checked = false;
                umur = "16+";
            }
        }

        private void tbNoHP_TextChanged(object sender, EventArgs e)
        {
            if ((tbNoHP.Text).All(Char.IsNumber))
            {
                epAttention.SetError(tbNoHP, "");
                epCorrect.SetError(tbNoHP, "Betul");
            }
            else
            {
                epCorrect.SetError(tbNoHP, "");
                epAttention.SetError(tbNoHP, "Input Hanya Boleh Huruf");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Form telah di reset.", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            foreach (Control clear in Controls)
            {
                if (clear is TextBox)
                {
                    clear.Text = "";
                    if (clear is CheckBox)
                    {
                        ((CheckBox)clear).Checked = false;
                        if (clear is ComboBox)
                        {
                            clear.Text = string.Empty;
                            if (clear is RichTextBox)
                            {
                                clear.Text = string.Empty;
                                if (clear is RadioButton)
                                {
                                    ((RadioButton)clear).Checked = false;
                                }
                            }
                        }
                    }
                }
            }
            this.Size = new Size(441, 369);
        }
    }
    }
