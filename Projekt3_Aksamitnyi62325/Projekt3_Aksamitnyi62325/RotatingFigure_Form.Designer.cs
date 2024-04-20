using System.Drawing;
using System.Windows.Forms;

namespace Projekt3_Aksamitnyi62325
{
    partial class RotatingFigure_Form
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
            this.components = new System.ComponentModel.Container();
            this.selectFigure_ComboBox = new System.Windows.Forms.ComboBox();
            this.figureAttributes_GroupBox = new System.Windows.Forms.GroupBox();
            this.function_Button = new System.Windows.Forms.Button();
            this.color_Label = new System.Windows.Forms.Label();
            this.color_Button = new System.Windows.Forms.Button();
            this.lineThickness_Label = new System.Windows.Forms.Label();
            this.lineThickness_Numeric = new System.Windows.Forms.NumericUpDown();
            this.lineStyle_Label = new System.Windows.Forms.Label();
            this.lineStyle_ComboBox = new System.Windows.Forms.ComboBox();
            this.inclinationAngle_TrackBar = new System.Windows.Forms.TrackBar();
            this.inclinationAngle_Label = new System.Windows.Forms.Label();
            this.width_TrackBar = new System.Windows.Forms.TrackBar();
            this.width_Label = new System.Windows.Forms.Label();
            this.height_TrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.height_Label = new System.Windows.Forms.Label();
            this.undo_Button = new System.Windows.Forms.Button();
            this.deleteFigure_Button = new System.Windows.Forms.Button();
            this.changeDirection_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.redo_Button = new System.Windows.Forms.Button();
            this.onPresentation_Button = new System.Windows.Forms.Button();
            this.automatic_RadioButton = new System.Windows.Forms.RadioButton();
            this.manual_RadioButton = new System.Windows.Forms.RadioButton();
            this.onPresentation_GroupBox = new System.Windows.Forms.GroupBox();
            this.sort_GroupBox = new System.Windows.Forms.GroupBox();
            this.volume_RadioButton = new System.Windows.Forms.RadioButton();
            this.width_RadioButton = new System.Windows.Forms.RadioButton();
            this.height_RadioButton = new System.Windows.Forms.RadioButton();
            this.surfaceArea_RadioButton = new System.Windows.Forms.RadioButton();
            this.arrange_GroupBox = new System.Windows.Forms.GroupBox();
            this.desc_RadioButton = new System.Windows.Forms.RadioButton();
            this.asc_RadioButton = new System.Windows.Forms.RadioButton();
            this.figureIndex_GroupBox = new System.Windows.Forms.GroupBox();
            this.figureIndex_Numeric = new System.Windows.Forms.NumericUpDown();
            this.next_Button = new System.Windows.Forms.Button();
            this.previous_Button = new System.Windows.Forms.Button();
            this.changeBackground_Button = new System.Windows.Forms.Button();
            this.offPresentation_Button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rotateTimer_Timer = new System.Windows.Forms.Timer(this.components);
            this.undoRedo_GroupBox = new System.Windows.Forms.GroupBox();
            this.figureAttributes_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclinationAngle_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_TrackBar)).BeginInit();
            this.onPresentation_GroupBox.SuspendLayout();
            this.sort_GroupBox.SuspendLayout();
            this.arrange_GroupBox.SuspendLayout();
            this.figureIndex_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figureIndex_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.undoRedo_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFigure_ComboBox
            // 
            this.selectFigure_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFigure_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFigure_ComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFigure_ComboBox.FormattingEnabled = true;
            this.selectFigure_ComboBox.Location = new System.Drawing.Point(1577, 4);
            this.selectFigure_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectFigure_ComboBox.Name = "selectFigure_ComboBox";
            this.selectFigure_ComboBox.Size = new System.Drawing.Size(303, 33);
            this.selectFigure_ComboBox.TabIndex = 1;
            this.selectFigure_ComboBox.TabStop = false;
            // 
            // figureAttributes_GroupBox
            // 
            this.figureAttributes_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.figureAttributes_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.figureAttributes_GroupBox.Controls.Add(this.function_Button);
            this.figureAttributes_GroupBox.Controls.Add(this.color_Label);
            this.figureAttributes_GroupBox.Controls.Add(this.color_Button);
            this.figureAttributes_GroupBox.Controls.Add(this.lineThickness_Label);
            this.figureAttributes_GroupBox.Controls.Add(this.lineThickness_Numeric);
            this.figureAttributes_GroupBox.Controls.Add(this.lineStyle_Label);
            this.figureAttributes_GroupBox.Controls.Add(this.lineStyle_ComboBox);
            this.figureAttributes_GroupBox.Controls.Add(this.inclinationAngle_TrackBar);
            this.figureAttributes_GroupBox.Controls.Add(this.inclinationAngle_Label);
            this.figureAttributes_GroupBox.Controls.Add(this.width_TrackBar);
            this.figureAttributes_GroupBox.Controls.Add(this.width_Label);
            this.figureAttributes_GroupBox.Controls.Add(this.height_TrackBar);
            this.figureAttributes_GroupBox.Controls.Add(this.label2);
            this.figureAttributes_GroupBox.Controls.Add(this.height_Label);
            this.figureAttributes_GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figureAttributes_GroupBox.Location = new System.Drawing.Point(1577, 47);
            this.figureAttributes_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.figureAttributes_GroupBox.Name = "figureAttributes_GroupBox";
            this.figureAttributes_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.figureAttributes_GroupBox.Size = new System.Drawing.Size(302, 506);
            this.figureAttributes_GroupBox.TabIndex = 2;
            this.figureAttributes_GroupBox.TabStop = false;
            this.figureAttributes_GroupBox.Text = "Figure attributes";
            // 
            // function_Button
            // 
            this.function_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.function_Button.Location = new System.Drawing.Point(9, 431);
            this.function_Button.Margin = new System.Windows.Forms.Padding(2);
            this.function_Button.Name = "function_Button";
            this.function_Button.Size = new System.Drawing.Size(287, 70);
            this.function_Button.TabIndex = 21;
            this.function_Button.Text = "Add";
            this.function_Button.UseVisualStyleBackColor = true;
            this.function_Button.Click += new System.EventHandler(this.function_Button_ClickHandler);
            // 
            // color_Label
            // 
            this.color_Label.AutoSize = true;
            this.color_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.color_Label.Location = new System.Drawing.Point(155, 394);
            this.color_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color_Label.Name = "color_Label";
            this.color_Label.Size = new System.Drawing.Size(50, 21);
            this.color_Label.TabIndex = 11;
            this.color_Label.Text = "Color";
            // 
            // color_Button
            // 
            this.color_Button.BackColor = System.Drawing.Color.Blue;
            this.color_Button.Location = new System.Drawing.Point(9, 389);
            this.color_Button.Margin = new System.Windows.Forms.Padding(2);
            this.color_Button.Name = "color_Button";
            this.color_Button.Size = new System.Drawing.Size(142, 38);
            this.color_Button.TabIndex = 10;
            this.color_Button.UseVisualStyleBackColor = false;
            this.color_Button.Click += new System.EventHandler(this.ChangeAttributes);
            // 
            // lineThickness_Label
            // 
            this.lineThickness_Label.AutoSize = true;
            this.lineThickness_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lineThickness_Label.Location = new System.Drawing.Point(155, 354);
            this.lineThickness_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineThickness_Label.Name = "lineThickness_Label";
            this.lineThickness_Label.Size = new System.Drawing.Size(111, 21);
            this.lineThickness_Label.TabIndex = 9;
            this.lineThickness_Label.Text = "Line thickness";
            // 
            // lineThickness_Numeric
            // 
            this.lineThickness_Numeric.Location = new System.Drawing.Point(9, 350);
            this.lineThickness_Numeric.Margin = new System.Windows.Forms.Padding(2);
            this.lineThickness_Numeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineThickness_Numeric.Name = "lineThickness_Numeric";
            this.lineThickness_Numeric.Size = new System.Drawing.Size(142, 32);
            this.lineThickness_Numeric.TabIndex = 8;
            this.lineThickness_Numeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.lineThickness_Numeric.ValueChanged += new System.EventHandler(this.ChangeAttributes);
            // 
            // lineStyle_Label
            // 
            this.lineStyle_Label.AutoSize = true;
            this.lineStyle_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lineStyle_Label.Location = new System.Drawing.Point(155, 316);
            this.lineStyle_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineStyle_Label.Name = "lineStyle_Label";
            this.lineStyle_Label.Size = new System.Drawing.Size(78, 21);
            this.lineStyle_Label.TabIndex = 7;
            this.lineStyle_Label.Text = "Line style";
            // 
            // lineStyle_ComboBox
            // 
            this.lineStyle_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineStyle_ComboBox.FormattingEnabled = true;
            this.lineStyle_ComboBox.Location = new System.Drawing.Point(9, 311);
            this.lineStyle_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.lineStyle_ComboBox.Name = "lineStyle_ComboBox";
            this.lineStyle_ComboBox.Size = new System.Drawing.Size(142, 33);
            this.lineStyle_ComboBox.TabIndex = 3;
            this.lineStyle_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.ChangeAttributes);
            // 
            // inclinationAngle_TrackBar
            // 
            this.inclinationAngle_TrackBar.Location = new System.Drawing.Point(4, 251);
            this.inclinationAngle_TrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.inclinationAngle_TrackBar.Maximum = 360;
            this.inclinationAngle_TrackBar.Name = "inclinationAngle_TrackBar";
            this.inclinationAngle_TrackBar.Size = new System.Drawing.Size(292, 45);
            this.inclinationAngle_TrackBar.TabIndex = 6;
            this.inclinationAngle_TrackBar.Value = 90;
            this.inclinationAngle_TrackBar.Scroll += new System.EventHandler(this.ChangeAttributes);
            // 
            // inclinationAngle_Label
            // 
            this.inclinationAngle_Label.AutoSize = true;
            this.inclinationAngle_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.inclinationAngle_Label.Location = new System.Drawing.Point(10, 185);
            this.inclinationAngle_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inclinationAngle_Label.Name = "inclinationAngle_Label";
            this.inclinationAngle_Label.Size = new System.Drawing.Size(138, 42);
            this.inclinationAngle_Label.TabIndex = 5;
            this.inclinationAngle_Label.Text = "Inclination angle\r\nof the figure : 90°";
            // 
            // width_TrackBar
            // 
            this.width_TrackBar.Location = new System.Drawing.Point(5, 146);
            this.width_TrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.width_TrackBar.Maximum = 1000;
            this.width_TrackBar.Name = "width_TrackBar";
            this.width_TrackBar.Size = new System.Drawing.Size(292, 45);
            this.width_TrackBar.TabIndex = 4;
            this.width_TrackBar.Value = 150;
            this.width_TrackBar.Scroll += new System.EventHandler(this.ChangeAttributes);
            // 
            // width_Label
            // 
            this.width_Label.AutoSize = true;
            this.width_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.width_Label.Location = new System.Drawing.Point(10, 116);
            this.width_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.width_Label.Name = "width_Label";
            this.width_Label.Size = new System.Drawing.Size(90, 21);
            this.width_Label.TabIndex = 3;
            this.width_Label.Text = "Width : 150";
            // 
            // height_TrackBar
            // 
            this.height_TrackBar.Location = new System.Drawing.Point(5, 77);
            this.height_TrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.height_TrackBar.Maximum = 300;
            this.height_TrackBar.Name = "height_TrackBar";
            this.height_TrackBar.Size = new System.Drawing.Size(292, 45);
            this.height_TrackBar.TabIndex = 2;
            this.height_TrackBar.Value = 200;
            this.height_TrackBar.Scroll += new System.EventHandler(this.ChangeAttributes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.height_Label.Location = new System.Drawing.Point(10, 47);
            this.height_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(99, 21);
            this.height_Label.TabIndex = 0;
            this.height_Label.Text = "Height : 200";
            // 
            // undo_Button
            // 
            this.undo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undo_Button.Enabled = false;
            this.undo_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.undo_Button.Location = new System.Drawing.Point(2, 20);
            this.undo_Button.Margin = new System.Windows.Forms.Padding(2);
            this.undo_Button.Name = "undo_Button";
            this.undo_Button.Size = new System.Drawing.Size(149, 70);
            this.undo_Button.TabIndex = 3;
            this.undo_Button.Text = "Undo";
            this.undo_Button.UseVisualStyleBackColor = true;
            this.undo_Button.Click += new System.EventHandler(this.undo_Button_ClickHandler);
            // 
            // deleteFigure_Button
            // 
            this.deleteFigure_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFigure_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteFigure_Button.Location = new System.Drawing.Point(1577, 739);
            this.deleteFigure_Button.Margin = new System.Windows.Forms.Padding(2);
            this.deleteFigure_Button.Name = "deleteFigure_Button";
            this.deleteFigure_Button.Size = new System.Drawing.Size(302, 70);
            this.deleteFigure_Button.TabIndex = 4;
            this.deleteFigure_Button.Text = "Delete this figure";
            this.deleteFigure_Button.UseVisualStyleBackColor = true;
            this.deleteFigure_Button.Click += new System.EventHandler(this.deleteFigure_Button_ClickHandler);
            // 
            // changeDirection_Button
            // 
            this.changeDirection_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDirection_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.changeDirection_Button.Location = new System.Drawing.Point(1577, 665);
            this.changeDirection_Button.Margin = new System.Windows.Forms.Padding(2);
            this.changeDirection_Button.Name = "changeDirection_Button";
            this.changeDirection_Button.Size = new System.Drawing.Size(302, 70);
            this.changeDirection_Button.TabIndex = 5;
            this.changeDirection_Button.Text = "Change the direction of the figure\'s rotation";
            this.changeDirection_Button.UseVisualStyleBackColor = true;
            this.changeDirection_Button.Click += new System.EventHandler(this.changeDirection_Button_ClickHadler);
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.reset_Button.Location = new System.Drawing.Point(4, 739);
            this.reset_Button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(302, 70);
            this.reset_Button.TabIndex = 6;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_ClickHandler);
            // 
            // redo_Button
            // 
            this.redo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redo_Button.Enabled = false;
            this.redo_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.redo_Button.Location = new System.Drawing.Point(153, 20);
            this.redo_Button.Margin = new System.Windows.Forms.Padding(2);
            this.redo_Button.Name = "redo_Button";
            this.redo_Button.Size = new System.Drawing.Size(149, 70);
            this.redo_Button.TabIndex = 7;
            this.redo_Button.Text = "Redo";
            this.redo_Button.UseVisualStyleBackColor = true;
            this.redo_Button.Click += new System.EventHandler(this.redo_Button_ClickHandler);
            // 
            // onPresentation_Button
            // 
            this.onPresentation_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.onPresentation_Button.Location = new System.Drawing.Point(0, 0);
            this.onPresentation_Button.Margin = new System.Windows.Forms.Padding(2);
            this.onPresentation_Button.Name = "onPresentation_Button";
            this.onPresentation_Button.Size = new System.Drawing.Size(302, 70);
            this.onPresentation_Button.TabIndex = 9;
            this.onPresentation_Button.Text = "Turn on presentation of the figures";
            this.onPresentation_Button.UseVisualStyleBackColor = true;
            this.onPresentation_Button.Click += new System.EventHandler(this.onPresentation_Button_ClickHandler);
            // 
            // automatic_RadioButton
            // 
            this.automatic_RadioButton.AutoSize = true;
            this.automatic_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.automatic_RadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.automatic_RadioButton.Location = new System.Drawing.Point(15, 74);
            this.automatic_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.automatic_RadioButton.Name = "automatic_RadioButton";
            this.automatic_RadioButton.Size = new System.Drawing.Size(108, 25);
            this.automatic_RadioButton.TabIndex = 10;
            this.automatic_RadioButton.TabStop = true;
            this.automatic_RadioButton.Text = "Automatic";
            this.automatic_RadioButton.UseVisualStyleBackColor = true;
            // 
            // manual_RadioButton
            // 
            this.manual_RadioButton.AutoSize = true;
            this.manual_RadioButton.Checked = true;
            this.manual_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.manual_RadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manual_RadioButton.Location = new System.Drawing.Point(176, 74);
            this.manual_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.manual_RadioButton.Name = "manual_RadioButton";
            this.manual_RadioButton.Size = new System.Drawing.Size(86, 25);
            this.manual_RadioButton.TabIndex = 11;
            this.manual_RadioButton.TabStop = true;
            this.manual_RadioButton.Text = "Manual";
            this.manual_RadioButton.UseVisualStyleBackColor = true;
            // 
            // onPresentation_GroupBox
            // 
            this.onPresentation_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.onPresentation_GroupBox.Controls.Add(this.onPresentation_Button);
            this.onPresentation_GroupBox.Controls.Add(this.manual_RadioButton);
            this.onPresentation_GroupBox.Controls.Add(this.automatic_RadioButton);
            this.onPresentation_GroupBox.Location = new System.Drawing.Point(4, 305);
            this.onPresentation_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.onPresentation_GroupBox.Name = "onPresentation_GroupBox";
            this.onPresentation_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.onPresentation_GroupBox.Size = new System.Drawing.Size(302, 118);
            this.onPresentation_GroupBox.TabIndex = 12;
            this.onPresentation_GroupBox.TabStop = false;
            // 
            // sort_GroupBox
            // 
            this.sort_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.sort_GroupBox.Controls.Add(this.volume_RadioButton);
            this.sort_GroupBox.Controls.Add(this.width_RadioButton);
            this.sort_GroupBox.Controls.Add(this.height_RadioButton);
            this.sort_GroupBox.Controls.Add(this.surfaceArea_RadioButton);
            this.sort_GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_GroupBox.Location = new System.Drawing.Point(4, 4);
            this.sort_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.sort_GroupBox.Name = "sort_GroupBox";
            this.sort_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.sort_GroupBox.Size = new System.Drawing.Size(302, 180);
            this.sort_GroupBox.TabIndex = 13;
            this.sort_GroupBox.TabStop = false;
            this.sort_GroupBox.Text = "Sort";
            // 
            // volume_RadioButton
            // 
            this.volume_RadioButton.AutoSize = true;
            this.volume_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_RadioButton.Location = new System.Drawing.Point(15, 143);
            this.volume_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.volume_RadioButton.Name = "volume_RadioButton";
            this.volume_RadioButton.Size = new System.Drawing.Size(87, 25);
            this.volume_RadioButton.TabIndex = 3;
            this.volume_RadioButton.Tag = "Sort";
            this.volume_RadioButton.Text = "Volume";
            this.volume_RadioButton.UseVisualStyleBackColor = true;
            this.volume_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // width_RadioButton
            // 
            this.width_RadioButton.AutoSize = true;
            this.width_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_RadioButton.Location = new System.Drawing.Point(15, 109);
            this.width_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.width_RadioButton.Name = "width_RadioButton";
            this.width_RadioButton.Size = new System.Drawing.Size(75, 25);
            this.width_RadioButton.TabIndex = 2;
            this.width_RadioButton.Tag = "Sort";
            this.width_RadioButton.Text = "Width";
            this.width_RadioButton.UseVisualStyleBackColor = true;
            this.width_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // height_RadioButton
            // 
            this.height_RadioButton.AutoSize = true;
            this.height_RadioButton.Checked = true;
            this.height_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_RadioButton.Location = new System.Drawing.Point(15, 74);
            this.height_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.height_RadioButton.Name = "height_RadioButton";
            this.height_RadioButton.Size = new System.Drawing.Size(80, 25);
            this.height_RadioButton.TabIndex = 1;
            this.height_RadioButton.TabStop = true;
            this.height_RadioButton.Tag = "Sort";
            this.height_RadioButton.Text = "Height";
            this.height_RadioButton.UseVisualStyleBackColor = true;
            this.height_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // surfaceArea_RadioButton
            // 
            this.surfaceArea_RadioButton.AutoSize = true;
            this.surfaceArea_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceArea_RadioButton.Location = new System.Drawing.Point(15, 40);
            this.surfaceArea_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.surfaceArea_RadioButton.Name = "surfaceArea_RadioButton";
            this.surfaceArea_RadioButton.Size = new System.Drawing.Size(122, 25);
            this.surfaceArea_RadioButton.TabIndex = 0;
            this.surfaceArea_RadioButton.Tag = "Sort";
            this.surfaceArea_RadioButton.Text = "Surface area";
            this.surfaceArea_RadioButton.UseVisualStyleBackColor = true;
            this.surfaceArea_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // arrange_GroupBox
            // 
            this.arrange_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.arrange_GroupBox.Controls.Add(this.desc_RadioButton);
            this.arrange_GroupBox.Controls.Add(this.asc_RadioButton);
            this.arrange_GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrange_GroupBox.Location = new System.Drawing.Point(4, 188);
            this.arrange_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.arrange_GroupBox.Name = "arrange_GroupBox";
            this.arrange_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.arrange_GroupBox.Size = new System.Drawing.Size(302, 113);
            this.arrange_GroupBox.TabIndex = 14;
            this.arrange_GroupBox.TabStop = false;
            this.arrange_GroupBox.Text = "Arrange";
            // 
            // desc_RadioButton
            // 
            this.desc_RadioButton.AutoSize = true;
            this.desc_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_RadioButton.Location = new System.Drawing.Point(15, 74);
            this.desc_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.desc_RadioButton.Name = "desc_RadioButton";
            this.desc_RadioButton.Size = new System.Drawing.Size(108, 25);
            this.desc_RadioButton.TabIndex = 1;
            this.desc_RadioButton.Text = "Desceding";
            this.desc_RadioButton.UseVisualStyleBackColor = true;
            this.desc_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // asc_RadioButton
            // 
            this.asc_RadioButton.AutoSize = true;
            this.asc_RadioButton.Checked = true;
            this.asc_RadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asc_RadioButton.Location = new System.Drawing.Point(15, 40);
            this.asc_RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.asc_RadioButton.Name = "asc_RadioButton";
            this.asc_RadioButton.Size = new System.Drawing.Size(98, 25);
            this.asc_RadioButton.TabIndex = 0;
            this.asc_RadioButton.TabStop = true;
            this.asc_RadioButton.Text = "Asceding";
            this.asc_RadioButton.UseVisualStyleBackColor = true;
            this.asc_RadioButton.CheckedChanged += new System.EventHandler(this.sort_RadioButton_ClickHandler);
            // 
            // figureIndex_GroupBox
            // 
            this.figureIndex_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.figureIndex_GroupBox.Controls.Add(this.figureIndex_Numeric);
            this.figureIndex_GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figureIndex_GroupBox.Location = new System.Drawing.Point(4, 427);
            this.figureIndex_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.figureIndex_GroupBox.Name = "figureIndex_GroupBox";
            this.figureIndex_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.figureIndex_GroupBox.Size = new System.Drawing.Size(302, 86);
            this.figureIndex_GroupBox.TabIndex = 15;
            this.figureIndex_GroupBox.TabStop = false;
            this.figureIndex_GroupBox.Text = "Figure index";
            // 
            // figureIndex_Numeric
            // 
            this.figureIndex_Numeric.Location = new System.Drawing.Point(5, 36);
            this.figureIndex_Numeric.Margin = new System.Windows.Forms.Padding(2);
            this.figureIndex_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.figureIndex_Numeric.Name = "figureIndex_Numeric";
            this.figureIndex_Numeric.Size = new System.Drawing.Size(293, 32);
            this.figureIndex_Numeric.TabIndex = 0;
            this.figureIndex_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.figureIndex_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.figureIndex_Numeric.Click += new System.EventHandler(this.figureIndex_Numeric_ValueChangedHandler);
            // 
            // next_Button
            // 
            this.next_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.next_Button.Location = new System.Drawing.Point(157, 517);
            this.next_Button.Margin = new System.Windows.Forms.Padding(2);
            this.next_Button.Name = "next_Button";
            this.next_Button.Size = new System.Drawing.Size(149, 70);
            this.next_Button.TabIndex = 17;
            this.next_Button.Text = "Next →";
            this.next_Button.UseVisualStyleBackColor = true;
            this.next_Button.Click += new System.EventHandler(this.next_Button_ClickHandler);
            // 
            // previous_Button
            // 
            this.previous_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.previous_Button.Location = new System.Drawing.Point(3, 517);
            this.previous_Button.Margin = new System.Windows.Forms.Padding(2);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.Size = new System.Drawing.Size(149, 70);
            this.previous_Button.TabIndex = 16;
            this.previous_Button.Text = "← Previous";
            this.previous_Button.UseVisualStyleBackColor = true;
            this.previous_Button.Click += new System.EventHandler(this.previous_Button_ClickHandler);
            // 
            // changeBackground_Button
            // 
            this.changeBackground_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.changeBackground_Button.Location = new System.Drawing.Point(4, 665);
            this.changeBackground_Button.Margin = new System.Windows.Forms.Padding(2);
            this.changeBackground_Button.Name = "changeBackground_Button";
            this.changeBackground_Button.Size = new System.Drawing.Size(302, 70);
            this.changeBackground_Button.TabIndex = 19;
            this.changeBackground_Button.Text = "Change background";
            this.changeBackground_Button.UseVisualStyleBackColor = true;
            this.changeBackground_Button.Click += new System.EventHandler(this.changeBackground_Button_ClickHandler);
            // 
            // offPresentation_Button
            // 
            this.offPresentation_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.offPresentation_Button.Location = new System.Drawing.Point(4, 591);
            this.offPresentation_Button.Margin = new System.Windows.Forms.Padding(2);
            this.offPresentation_Button.Name = "offPresentation_Button";
            this.offPresentation_Button.Size = new System.Drawing.Size(302, 70);
            this.offPresentation_Button.TabIndex = 18;
            this.offPresentation_Button.Text = "Turn off presentation of the figures";
            this.offPresentation_Button.UseVisualStyleBackColor = true;
            this.offPresentation_Button.Click += new System.EventHandler(this.offPresentation_Button_ClickHandler);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(310, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1263, 805);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClickHandler);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pic_MouseLeaveHandler);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMoveHandler);
            // 
            // rotateTimer_Timer
            // 
            this.rotateTimer_Timer.Tick += new System.EventHandler(this.rotateTimer_Timer_TickHandler);
            // 
            // undoRedo_GroupBox
            // 
            this.undoRedo_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undoRedo_GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.undoRedo_GroupBox.Controls.Add(this.undo_Button);
            this.undoRedo_GroupBox.Controls.Add(this.redo_Button);
            this.undoRedo_GroupBox.Location = new System.Drawing.Point(1577, 558);
            this.undoRedo_GroupBox.Name = "undoRedo_GroupBox";
            this.undoRedo_GroupBox.Size = new System.Drawing.Size(303, 103);
            this.undoRedo_GroupBox.TabIndex = 21;
            this.undoRedo_GroupBox.TabStop = false;
            // 
            // RotatingFigure_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1885, 823);
            this.Controls.Add(this.undoRedo_GroupBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.changeBackground_Button);
            this.Controls.Add(this.offPresentation_Button);
            this.Controls.Add(this.next_Button);
            this.Controls.Add(this.previous_Button);
            this.Controls.Add(this.figureIndex_GroupBox);
            this.Controls.Add(this.arrange_GroupBox);
            this.Controls.Add(this.sort_GroupBox);
            this.Controls.Add(this.onPresentation_GroupBox);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.changeDirection_Button);
            this.Controls.Add(this.deleteFigure_Button);
            this.Controls.Add(this.figureAttributes_GroupBox);
            this.Controls.Add(this.selectFigure_ComboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1901, 862);
            this.Name = "RotatingFigure_Form";
            this.Text = "Rotating Figure";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Polyhedrons_Form_CloseHandler);
            this.Load += new System.EventHandler(this.Polyhedrons_Form_LoadHandler);
            this.figureAttributes_GroupBox.ResumeLayout(false);
            this.figureAttributes_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inclinationAngle_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_TrackBar)).EndInit();
            this.onPresentation_GroupBox.ResumeLayout(false);
            this.onPresentation_GroupBox.PerformLayout();
            this.sort_GroupBox.ResumeLayout(false);
            this.sort_GroupBox.PerformLayout();
            this.arrange_GroupBox.ResumeLayout(false);
            this.arrange_GroupBox.PerformLayout();
            this.figureIndex_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.figureIndex_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.undoRedo_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox selectFigure_ComboBox;
        private GroupBox figureAttributes_GroupBox;
        private TrackBar height_TrackBar;
        private Label label2;
        private Label height_Label;
        private ComboBox lineStyle_ComboBox;
        private TrackBar inclinationAngle_TrackBar;
        private Label inclinationAngle_Label;
        private TrackBar width_TrackBar;
        private Label width_Label;
        private Label color_Label;
        private Button color_Button;
        private Label lineThickness_Label;
        private NumericUpDown lineThickness_Numeric;
        private Label lineStyle_Label;
        private Button undo_Button;
        private Button deleteFigure_Button;
        private Button changeDirection_Button;
        private Button reset_Button;
        private Button redo_Button;
        private Button onPresentation_Button;
        private RadioButton automatic_RadioButton;
        private RadioButton manual_RadioButton;
        private GroupBox onPresentation_GroupBox;
        private GroupBox sort_GroupBox;
        private RadioButton surfaceArea_RadioButton;
        private RadioButton volume_RadioButton;
        private RadioButton width_RadioButton;
        private RadioButton height_RadioButton;
        private GroupBox arrange_GroupBox;
        private RadioButton desc_RadioButton;
        private RadioButton asc_RadioButton;
        private GroupBox figureIndex_GroupBox;
        private NumericUpDown figureIndex_Numeric;
        private Button next_Button;
        private Button previous_Button;
        private Button changeBackground_Button;
        private Button offPresentation_Button;
        private PictureBox pictureBox;
        private System.Windows.Forms.Timer rotateTimer_Timer;
        private Button function_Button;
        private GroupBox undoRedo_GroupBox;
    }
}