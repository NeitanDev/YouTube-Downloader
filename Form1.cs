using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube_Downloader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        String argumentos = "";

        private void Form1_Load( object sender , EventArgs e ) {

        }


        private void RadioButton1_CheckedChanged( object sender , EventArgs e ) {

        }

        private void RadioButton2_CheckedChanged( object sender , EventArgs e ) {

        }

        private void RadioButton3_CheckedChanged( object sender , EventArgs e ) {

        }

        private void RadioButton4_CheckedChanged( object sender , EventArgs e ) {

        }

        private void GroupBox2_Enter( object sender , EventArgs e ) {

        }

        private void Button1_Click( object sender , EventArgs e ) {
            if ( radioButton2.Checked ) {
                if ( radioButton4.Checked ) argumentos = "-x --audio-format mp3 --audio-quality 7";
                if ( radioButton3.Checked ) argumentos = " -x --audio - format mp3--audio - quality 0";
            }
            if ( radioButton1.Checked ) {
                if ( radioButton4.Checked ) argumentos = "-f \"(mp4)[height<=480]\"";
                if ( radioButton3.Checked ) argumentos = "-f \"(mp4)[height<=720]\"";

                ProcessStartInfo AbrirExploradorDeArquivos = new ProcessStartInfo();

                //Abre o cmd do Windows
                AbrirExploradorDeArquivos.FileName = "cmd.exe";

                //informa ao cmd qual processo ele deve executar
                AbrirExploradorDeArquivos.Arguments = "cd C:/Users/natan/Music/ youtube-dl.exe" + argumentos + textBox1.Text;

                Process.Start( AbrirExploradorDeArquivos );
            }
        }
    }
}
