namespace game_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_speakers = new System.Windows.Forms.GroupBox();
            this.rb_51ch = new System.Windows.Forms.RadioButton();
            this.rb_4ch = new System.Windows.Forms.RadioButton();
            this.rb_21ch = new System.Windows.Forms.RadioButton();
            this.rb_2ch = new System.Windows.Forms.RadioButton();
            this.but_play = new System.Windows.Forms.Button();
            this.but_stop = new System.Windows.Forms.Button();
            this.cb_bsidrev = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_vol = new System.Windows.Forms.Button();
            this.Gb_bak_Rig = new System.Windows.Forms.GroupBox();
            this.lab_br = new System.Windows.Forms.Label();
            this.Hsb_br = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_mas = new System.Windows.Forms.Label();
            this.Hsb_Master = new System.Windows.Forms.HScrollBar();
            this.Gb_bak_lef = new System.Windows.Forms.GroupBox();
            this.lab_bl = new System.Windows.Forms.Label();
            this.Hsb_bl = new System.Windows.Forms.HScrollBar();
            this.Gb_sub = new System.Windows.Forms.GroupBox();
            this.lab_sub = new System.Windows.Forms.Label();
            this.Hsb_sub = new System.Windows.Forms.HScrollBar();
            this.Gb_fro_rig = new System.Windows.Forms.GroupBox();
            this.lab_fr = new System.Windows.Forms.Label();
            this.Hsb_fr = new System.Windows.Forms.HScrollBar();
            this.Gb_fro_lef = new System.Windows.Forms.GroupBox();
            this.lab_fl = new System.Windows.Forms.Label();
            this.Hsb_fl = new System.Windows.Forms.HScrollBar();
            this.Gb_fro_cen = new System.Windows.Forms.GroupBox();
            this.lab_fc = new System.Windows.Forms.Label();
            this.Hsb_fc = new System.Windows.Forms.HScrollBar();
            this.lb_mus = new System.Windows.Forms.ListBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.cb_loop = new System.Windows.Forms.CheckBox();
            this.But_Licence = new System.Windows.Forms.Button();
            this.gb_decord = new System.Windows.Forms.GroupBox();
            this.Rb_surround = new System.Windows.Forms.RadioButton();
            this.Rb_stereo = new System.Windows.Forms.RadioButton();
            this.gb_speakers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Gb_bak_Rig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gb_bak_lef.SuspendLayout();
            this.Gb_sub.SuspendLayout();
            this.Gb_fro_rig.SuspendLayout();
            this.Gb_fro_lef.SuspendLayout();
            this.Gb_fro_cen.SuspendLayout();
            this.gb_decord.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_speakers
            // 
            this.gb_speakers.Controls.Add(this.rb_51ch);
            this.gb_speakers.Controls.Add(this.rb_4ch);
            this.gb_speakers.Controls.Add(this.rb_21ch);
            this.gb_speakers.Controls.Add(this.rb_2ch);
            this.gb_speakers.Location = new System.Drawing.Point(12, 12);
            this.gb_speakers.Name = "gb_speakers";
            this.gb_speakers.Size = new System.Drawing.Size(138, 75);
            this.gb_speakers.TabIndex = 0;
            this.gb_speakers.TabStop = false;
            this.gb_speakers.Text = "Speakers(Virtual or Multi speakers)";
            // 
            // rb_51ch
            // 
            this.rb_51ch.AutoSize = true;
            this.rb_51ch.Location = new System.Drawing.Point(67, 53);
            this.rb_51ch.Name = "rb_51ch";
            this.rb_51ch.Size = new System.Drawing.Size(49, 16);
            this.rb_51ch.TabIndex = 5;
            this.rb_51ch.Text = "5.1ch";
            this.rb_51ch.UseVisualStyleBackColor = true;
            this.rb_51ch.CheckedChanged += new System.EventHandler(this.Rb_51ch_CheckedChanged);
            // 
            // rb_4ch
            // 
            this.rb_4ch.AutoSize = true;
            this.rb_4ch.Location = new System.Drawing.Point(6, 53);
            this.rb_4ch.Name = "rb_4ch";
            this.rb_4ch.Size = new System.Drawing.Size(49, 16);
            this.rb_4ch.TabIndex = 2;
            this.rb_4ch.Text = "Quad";
            this.rb_4ch.UseVisualStyleBackColor = true;
            this.rb_4ch.CheckedChanged += new System.EventHandler(this.Rb_4ch_CheckedChanged);
            // 
            // rb_21ch
            // 
            this.rb_21ch.AutoSize = true;
            this.rb_21ch.Location = new System.Drawing.Point(67, 31);
            this.rb_21ch.Name = "rb_21ch";
            this.rb_21ch.Size = new System.Drawing.Size(49, 16);
            this.rb_21ch.TabIndex = 4;
            this.rb_21ch.Text = "2.1ch";
            this.rb_21ch.UseVisualStyleBackColor = true;
            this.rb_21ch.CheckedChanged += new System.EventHandler(this.Rb_21ch_CheckedChanged);
            // 
            // rb_2ch
            // 
            this.rb_2ch.AutoSize = true;
            this.rb_2ch.Checked = true;
            this.rb_2ch.Location = new System.Drawing.Point(6, 31);
            this.rb_2ch.Name = "rb_2ch";
            this.rb_2ch.Size = new System.Drawing.Size(56, 16);
            this.rb_2ch.TabIndex = 1;
            this.rb_2ch.TabStop = true;
            this.rb_2ch.Text = "Stereo";
            this.rb_2ch.UseVisualStyleBackColor = true;
            this.rb_2ch.CheckedChanged += new System.EventHandler(this.Rb_2ch_CheckedChanged);
            // 
            // but_play
            // 
            this.but_play.Location = new System.Drawing.Point(75, 195);
            this.but_play.Name = "but_play";
            this.but_play.Size = new System.Drawing.Size(75, 23);
            this.but_play.TabIndex = 1;
            this.but_play.Text = "Music List";
            this.but_play.UseVisualStyleBackColor = true;
            this.but_play.Click += new System.EventHandler(this.But_play_Click);
            // 
            // but_stop
            // 
            this.but_stop.Location = new System.Drawing.Point(75, 224);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(75, 23);
            this.but_stop.TabIndex = 3;
            this.but_stop.Text = "Stop";
            this.but_stop.UseVisualStyleBackColor = true;
            this.but_stop.Click += new System.EventHandler(this.But_stop_Click);
            // 
            // cb_bsidrev
            // 
            this.cb_bsidrev.AutoSize = true;
            this.cb_bsidrev.Location = new System.Drawing.Point(214, 37);
            this.cb_bsidrev.Name = "cb_bsidrev";
            this.cb_bsidrev.Size = new System.Drawing.Size(122, 16);
            this.cb_bsidrev.TabIndex = 3;
            this.cb_bsidrev.Text = "Back Side Reverse";
            this.cb_bsidrev.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_vol);
            this.groupBox2.Controls.Add(this.cb_bsidrev);
            this.groupBox2.Controls.Add(this.Gb_bak_Rig);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Gb_bak_lef);
            this.groupBox2.Controls.Add(this.Gb_sub);
            this.groupBox2.Controls.Add(this.Gb_fro_rig);
            this.groupBox2.Controls.Add(this.Gb_fro_lef);
            this.groupBox2.Controls.Add(this.Gb_fro_cen);
            this.groupBox2.Location = new System.Drawing.Point(156, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // but_vol
            // 
            this.but_vol.Location = new System.Drawing.Point(337, 33);
            this.but_vol.Name = "but_vol";
            this.but_vol.Size = new System.Drawing.Size(75, 23);
            this.but_vol.TabIndex = 12;
            this.but_vol.Text = "Vol Set";
            this.but_vol.UseVisualStyleBackColor = true;
            this.but_vol.Click += new System.EventHandler(this.But_vol_Click);
            // 
            // Gb_bak_Rig
            // 
            this.Gb_bak_Rig.Controls.Add(this.lab_br);
            this.Gb_bak_Rig.Controls.Add(this.Hsb_br);
            this.Gb_bak_Rig.Location = new System.Drawing.Point(212, 150);
            this.Gb_bak_Rig.Name = "Gb_bak_Rig";
            this.Gb_bak_Rig.Size = new System.Drawing.Size(200, 38);
            this.Gb_bak_Rig.TabIndex = 10;
            this.Gb_bak_Rig.TabStop = false;
            this.Gb_bak_Rig.Text = "Back Right";
            // 
            // lab_br
            // 
            this.lab_br.AutoSize = true;
            this.lab_br.Location = new System.Drawing.Point(174, 18);
            this.lab_br.Name = "lab_br";
            this.lab_br.Size = new System.Drawing.Size(25, 12);
            this.lab_br.TabIndex = 13;
            this.lab_br.Text = "99.9";
            // 
            // Hsb_br
            // 
            this.Hsb_br.Location = new System.Drawing.Point(2, 13);
            this.Hsb_br.Name = "Hsb_br";
            this.Hsb_br.Size = new System.Drawing.Size(173, 17);
            this.Hsb_br.TabIndex = 2;
            this.Hsb_br.ValueChanged += new System.EventHandler(this.Hsb_br_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_mas);
            this.groupBox1.Controls.Add(this.Hsb_Master);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 38);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Volume";
            // 
            // lab_mas
            // 
            this.lab_mas.AutoSize = true;
            this.lab_mas.Location = new System.Drawing.Point(174, 18);
            this.lab_mas.Name = "lab_mas";
            this.lab_mas.Size = new System.Drawing.Size(25, 12);
            this.lab_mas.TabIndex = 13;
            this.lab_mas.Text = "99.9";
            // 
            // Hsb_Master
            // 
            this.Hsb_Master.Location = new System.Drawing.Point(2, 13);
            this.Hsb_Master.Name = "Hsb_Master";
            this.Hsb_Master.Size = new System.Drawing.Size(173, 17);
            this.Hsb_Master.TabIndex = 2;
            this.Hsb_Master.ValueChanged += new System.EventHandler(this.Hsb_Master_ValueChanged);
            // 
            // Gb_bak_lef
            // 
            this.Gb_bak_lef.Controls.Add(this.lab_bl);
            this.Gb_bak_lef.Controls.Add(this.Hsb_bl);
            this.Gb_bak_lef.Location = new System.Drawing.Point(6, 150);
            this.Gb_bak_lef.Name = "Gb_bak_lef";
            this.Gb_bak_lef.Size = new System.Drawing.Size(200, 38);
            this.Gb_bak_lef.TabIndex = 9;
            this.Gb_bak_lef.TabStop = false;
            this.Gb_bak_lef.Text = "Back Left";
            // 
            // lab_bl
            // 
            this.lab_bl.AutoSize = true;
            this.lab_bl.Location = new System.Drawing.Point(174, 18);
            this.lab_bl.Name = "lab_bl";
            this.lab_bl.Size = new System.Drawing.Size(25, 12);
            this.lab_bl.TabIndex = 13;
            this.lab_bl.Text = "99.9";
            // 
            // Hsb_bl
            // 
            this.Hsb_bl.Location = new System.Drawing.Point(2, 13);
            this.Hsb_bl.Name = "Hsb_bl";
            this.Hsb_bl.Size = new System.Drawing.Size(173, 17);
            this.Hsb_bl.TabIndex = 2;
            this.Hsb_bl.ValueChanged += new System.EventHandler(this.Hsb_bl_ValueChanged);
            // 
            // Gb_sub
            // 
            this.Gb_sub.Controls.Add(this.lab_sub);
            this.Gb_sub.Controls.Add(this.Hsb_sub);
            this.Gb_sub.Location = new System.Drawing.Point(212, 62);
            this.Gb_sub.Name = "Gb_sub";
            this.Gb_sub.Size = new System.Drawing.Size(200, 38);
            this.Gb_sub.TabIndex = 8;
            this.Gb_sub.TabStop = false;
            this.Gb_sub.Text = "Sub(Low Freqency)";
            // 
            // lab_sub
            // 
            this.lab_sub.AutoSize = true;
            this.lab_sub.Location = new System.Drawing.Point(174, 18);
            this.lab_sub.Name = "lab_sub";
            this.lab_sub.Size = new System.Drawing.Size(25, 12);
            this.lab_sub.TabIndex = 13;
            this.lab_sub.Text = "99.9";
            // 
            // Hsb_sub
            // 
            this.Hsb_sub.Location = new System.Drawing.Point(2, 13);
            this.Hsb_sub.Name = "Hsb_sub";
            this.Hsb_sub.Size = new System.Drawing.Size(173, 17);
            this.Hsb_sub.TabIndex = 2;
            this.Hsb_sub.ValueChanged += new System.EventHandler(this.Hsb_sub_ValueChanged);
            // 
            // Gb_fro_rig
            // 
            this.Gb_fro_rig.Controls.Add(this.lab_fr);
            this.Gb_fro_rig.Controls.Add(this.Hsb_fr);
            this.Gb_fro_rig.Location = new System.Drawing.Point(212, 106);
            this.Gb_fro_rig.Name = "Gb_fro_rig";
            this.Gb_fro_rig.Size = new System.Drawing.Size(200, 38);
            this.Gb_fro_rig.TabIndex = 7;
            this.Gb_fro_rig.TabStop = false;
            this.Gb_fro_rig.Text = "Front Right";
            // 
            // lab_fr
            // 
            this.lab_fr.AutoSize = true;
            this.lab_fr.Location = new System.Drawing.Point(174, 18);
            this.lab_fr.Name = "lab_fr";
            this.lab_fr.Size = new System.Drawing.Size(25, 12);
            this.lab_fr.TabIndex = 13;
            this.lab_fr.Text = "99.9";
            // 
            // Hsb_fr
            // 
            this.Hsb_fr.Location = new System.Drawing.Point(2, 13);
            this.Hsb_fr.Name = "Hsb_fr";
            this.Hsb_fr.Size = new System.Drawing.Size(173, 17);
            this.Hsb_fr.TabIndex = 2;
            this.Hsb_fr.ValueChanged += new System.EventHandler(this.Hsb_fr_ValueChanged);
            // 
            // Gb_fro_lef
            // 
            this.Gb_fro_lef.Controls.Add(this.lab_fl);
            this.Gb_fro_lef.Controls.Add(this.Hsb_fl);
            this.Gb_fro_lef.Location = new System.Drawing.Point(6, 106);
            this.Gb_fro_lef.Name = "Gb_fro_lef";
            this.Gb_fro_lef.Size = new System.Drawing.Size(200, 38);
            this.Gb_fro_lef.TabIndex = 6;
            this.Gb_fro_lef.TabStop = false;
            this.Gb_fro_lef.Text = "Front Left";
            // 
            // lab_fl
            // 
            this.lab_fl.AutoSize = true;
            this.lab_fl.Location = new System.Drawing.Point(174, 18);
            this.lab_fl.Name = "lab_fl";
            this.lab_fl.Size = new System.Drawing.Size(25, 12);
            this.lab_fl.TabIndex = 13;
            this.lab_fl.Text = "99.9";
            // 
            // Hsb_fl
            // 
            this.Hsb_fl.Location = new System.Drawing.Point(2, 13);
            this.Hsb_fl.Name = "Hsb_fl";
            this.Hsb_fl.Size = new System.Drawing.Size(173, 17);
            this.Hsb_fl.TabIndex = 2;
            this.Hsb_fl.ValueChanged += new System.EventHandler(this.Hsb_fl_ValueChanged);
            // 
            // Gb_fro_cen
            // 
            this.Gb_fro_cen.Controls.Add(this.lab_fc);
            this.Gb_fro_cen.Controls.Add(this.Hsb_fc);
            this.Gb_fro_cen.Location = new System.Drawing.Point(6, 62);
            this.Gb_fro_cen.Name = "Gb_fro_cen";
            this.Gb_fro_cen.Size = new System.Drawing.Size(200, 38);
            this.Gb_fro_cen.TabIndex = 5;
            this.Gb_fro_cen.TabStop = false;
            this.Gb_fro_cen.Text = "Front Center";
            // 
            // lab_fc
            // 
            this.lab_fc.AutoSize = true;
            this.lab_fc.Location = new System.Drawing.Point(174, 18);
            this.lab_fc.Name = "lab_fc";
            this.lab_fc.Size = new System.Drawing.Size(25, 12);
            this.lab_fc.TabIndex = 12;
            this.lab_fc.Text = "99.9";
            // 
            // Hsb_fc
            // 
            this.Hsb_fc.Location = new System.Drawing.Point(2, 13);
            this.Hsb_fc.Name = "Hsb_fc";
            this.Hsb_fc.Size = new System.Drawing.Size(173, 17);
            this.Hsb_fc.TabIndex = 2;
            this.Hsb_fc.ValueChanged += new System.EventHandler(this.Hsb_fc_ValueChanged);
            // 
            // lb_mus
            // 
            this.lb_mus.FormattingEnabled = true;
            this.lb_mus.ItemHeight = 12;
            this.lb_mus.Location = new System.Drawing.Point(162, 215);
            this.lb_mus.Name = "lb_mus";
            this.lb_mus.ScrollAlwaysVisible = true;
            this.lb_mus.Size = new System.Drawing.Size(418, 112);
            this.lb_mus.TabIndex = 2;
            this.lb_mus.SelectedIndexChanged += new System.EventHandler(this.Lb_mus_SelectedIndexChanged);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(12, 303);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(75, 23);
            this.but_exit.TabIndex = 5;
            this.but_exit.Text = "Exit";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.But_exit_Click);
            // 
            // cb_loop
            // 
            this.cb_loop.AutoSize = true;
            this.cb_loop.Location = new System.Drawing.Point(18, 162);
            this.cb_loop.Name = "cb_loop";
            this.cb_loop.Size = new System.Drawing.Size(48, 16);
            this.cb_loop.TabIndex = 4;
            this.cb_loop.Text = "Loop";
            this.cb_loop.UseVisualStyleBackColor = true;
            // 
            // But_Licence
            // 
            this.But_Licence.Location = new System.Drawing.Point(75, 274);
            this.But_Licence.Name = "But_Licence";
            this.But_Licence.Size = new System.Drawing.Size(75, 23);
            this.But_Licence.TabIndex = 6;
            this.But_Licence.Text = "Licence";
            this.But_Licence.UseVisualStyleBackColor = true;
            this.But_Licence.Click += new System.EventHandler(this.But_Licence_Click);
            // 
            // gb_decord
            // 
            this.gb_decord.Controls.Add(this.Rb_surround);
            this.gb_decord.Controls.Add(this.Rb_stereo);
            this.gb_decord.Location = new System.Drawing.Point(12, 93);
            this.gb_decord.Name = "gb_decord";
            this.gb_decord.Size = new System.Drawing.Size(138, 63);
            this.gb_decord.TabIndex = 7;
            this.gb_decord.TabStop = false;
            this.gb_decord.Text = "Decord(Quad/5.1ch)";
            // 
            // Rb_surround
            // 
            this.Rb_surround.AutoSize = true;
            this.Rb_surround.Checked = true;
            this.Rb_surround.Location = new System.Drawing.Point(6, 38);
            this.Rb_surround.Name = "Rb_surround";
            this.Rb_surround.Size = new System.Drawing.Size(68, 16);
            this.Rb_surround.TabIndex = 4;
            this.Rb_surround.TabStop = true;
            this.Rb_surround.Text = "Surround";
            this.Rb_surround.UseVisualStyleBackColor = true;
            this.Rb_surround.CheckedChanged += new System.EventHandler(this.Rb_surround_CheckedChanged);
            // 
            // Rb_stereo
            // 
            this.Rb_stereo.AutoSize = true;
            this.Rb_stereo.Location = new System.Drawing.Point(6, 18);
            this.Rb_stereo.Name = "Rb_stereo";
            this.Rb_stereo.Size = new System.Drawing.Size(85, 16);
            this.Rb_stereo.TabIndex = 1;
            this.Rb_stereo.Text = "Multi Stereo";
            this.Rb_stereo.UseVisualStyleBackColor = true;
            this.Rb_stereo.CheckedChanged += new System.EventHandler(this.Rb_stereo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 338);
            this.Controls.Add(this.gb_decord);
            this.Controls.Add(this.But_Licence);
            this.Controls.Add(this.cb_loop);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.lb_mus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.but_play);
            this.Controls.Add(this.gb_speakers);
            this.Name = "Form1";
            this.Text = "Audio Player たいたんぱー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gb_speakers.ResumeLayout(false);
            this.gb_speakers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Gb_bak_Rig.ResumeLayout(false);
            this.Gb_bak_Rig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gb_bak_lef.ResumeLayout(false);
            this.Gb_bak_lef.PerformLayout();
            this.Gb_sub.ResumeLayout(false);
            this.Gb_sub.PerformLayout();
            this.Gb_fro_rig.ResumeLayout(false);
            this.Gb_fro_rig.PerformLayout();
            this.Gb_fro_lef.ResumeLayout(false);
            this.Gb_fro_lef.PerformLayout();
            this.Gb_fro_cen.ResumeLayout(false);
            this.Gb_fro_cen.PerformLayout();
            this.gb_decord.ResumeLayout(false);
            this.gb_decord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_speakers;
        private System.Windows.Forms.RadioButton rb_51ch;
        private System.Windows.Forms.RadioButton rb_4ch;
        private System.Windows.Forms.RadioButton rb_21ch;
        private System.Windows.Forms.RadioButton rb_2ch;
        private System.Windows.Forms.Button but_play;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.CheckBox cb_bsidrev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Gb_fro_cen;
        private System.Windows.Forms.HScrollBar Hsb_fc;
        private System.Windows.Forms.GroupBox Gb_fro_lef;
        private System.Windows.Forms.HScrollBar Hsb_fl;
        private System.Windows.Forms.GroupBox Gb_fro_rig;
        private System.Windows.Forms.HScrollBar Hsb_fr;
        private System.Windows.Forms.GroupBox Gb_bak_Rig;
        private System.Windows.Forms.HScrollBar Hsb_br;
        private System.Windows.Forms.GroupBox Gb_bak_lef;
        private System.Windows.Forms.HScrollBar Hsb_bl;
        private System.Windows.Forms.GroupBox Gb_sub;
        private System.Windows.Forms.HScrollBar Hsb_sub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar Hsb_Master;
        private System.Windows.Forms.Label lab_mas;
        private System.Windows.Forms.Label lab_br;
        private System.Windows.Forms.Label lab_bl;
        private System.Windows.Forms.Label lab_sub;
        private System.Windows.Forms.Label lab_fr;
        private System.Windows.Forms.Label lab_fl;
        private System.Windows.Forms.Label lab_fc;
        private System.Windows.Forms.Button but_vol;
        private System.Windows.Forms.ListBox lb_mus;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.CheckBox cb_loop;
        private System.Windows.Forms.Button But_Licence;
        private System.Windows.Forms.GroupBox gb_decord;
        private System.Windows.Forms.RadioButton Rb_surround;
        private System.Windows.Forms.RadioButton Rb_stereo;
    }
}