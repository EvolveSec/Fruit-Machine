<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.holdButton1 = New System.Windows.Forms.Button()
        Me.holdButton2 = New System.Windows.Forms.Button()
        Me.holdButton3 = New System.Windows.Forms.Button()
        Me.spinButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bankLabel = New System.Windows.Forms.Label()
        Me.creditLabel = New System.Windows.Forms.Label()
        Me.nudgeButton1 = New System.Windows.Forms.Button()
        Me.nudgeButton2 = New System.Windows.Forms.Button()
        Me.nudgeButton3 = New System.Windows.Forms.Button()
        Me.creditsButton = New System.Windows.Forms.Button()
        Me.reelImageLow3 = New System.Windows.Forms.PictureBox()
        Me.reelImageLow2 = New System.Windows.Forms.PictureBox()
        Me.reelImageLow1 = New System.Windows.Forms.PictureBox()
        Me.reelImageTop3 = New System.Windows.Forms.PictureBox()
        Me.reelImageTop2 = New System.Windows.Forms.PictureBox()
        Me.reelImageTop1 = New System.Windows.Forms.PictureBox()
        Me.reelImage3 = New System.Windows.Forms.PictureBox()
        Me.reelImage2 = New System.Windows.Forms.PictureBox()
        Me.reelImage1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.stopButton = New System.Windows.Forms.Button()
        Me.creditsButton2 = New System.Windows.Forms.Button()
        Me.nudgeImage = New System.Windows.Forms.PictureBox()
        Me.holdImage = New System.Windows.Forms.PictureBox()
        Me.BonusBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.reelImageLow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImageLow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImageLow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImageTop3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImageTop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImageTop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reelImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudgeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.holdImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'holdButton1
        '
        Me.holdButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.holdButton1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.holdButton1.Location = New System.Drawing.Point(113, 414)
        Me.holdButton1.Name = "holdButton1"
        Me.holdButton1.Size = New System.Drawing.Size(111, 45)
        Me.holdButton1.TabIndex = 3
        Me.holdButton1.Text = "Hold"
        Me.holdButton1.UseVisualStyleBackColor = False
        '
        'holdButton2
        '
        Me.holdButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.holdButton2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.holdButton2.Location = New System.Drawing.Point(254, 414)
        Me.holdButton2.Name = "holdButton2"
        Me.holdButton2.Size = New System.Drawing.Size(113, 45)
        Me.holdButton2.TabIndex = 4
        Me.holdButton2.Text = "Hold"
        Me.holdButton2.UseVisualStyleBackColor = False
        '
        'holdButton3
        '
        Me.holdButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.holdButton3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.holdButton3.Location = New System.Drawing.Point(396, 414)
        Me.holdButton3.Name = "holdButton3"
        Me.holdButton3.Size = New System.Drawing.Size(111, 45)
        Me.holdButton3.TabIndex = 5
        Me.holdButton3.Text = "Hold"
        Me.holdButton3.UseVisualStyleBackColor = False
        '
        'spinButton
        '
        Me.spinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.spinButton.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spinButton.Location = New System.Drawing.Point(439, 522)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(75, 78)
        Me.spinButton.TabIndex = 6
        Me.spinButton.Text = "Spin"
        Me.spinButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 35
        '
        'bankLabel
        '
        Me.bankLabel.AutoSize = True
        Me.bankLabel.BackColor = System.Drawing.Color.Black
        Me.bankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankLabel.ForeColor = System.Drawing.Color.White
        Me.bankLabel.Location = New System.Drawing.Point(462, 90)
        Me.bankLabel.Name = "bankLabel"
        Me.bankLabel.Size = New System.Drawing.Size(130, 20)
        Me.bankLabel.TabIndex = 7
        Me.bankLabel.Text = "Bank Balance - 5"
        '
        'creditLabel
        '
        Me.creditLabel.AutoSize = True
        Me.creditLabel.BackColor = System.Drawing.Color.Black
        Me.creditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditLabel.ForeColor = System.Drawing.Color.White
        Me.creditLabel.Location = New System.Drawing.Point(457, 110)
        Me.creditLabel.Name = "creditLabel"
        Me.creditLabel.Size = New System.Drawing.Size(135, 20)
        Me.creditLabel.TabIndex = 8
        Me.creditLabel.Text = "Credit Balance - 0"
        '
        'nudgeButton1
        '
        Me.nudgeButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudgeButton1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudgeButton1.Location = New System.Drawing.Point(113, 465)
        Me.nudgeButton1.Name = "nudgeButton1"
        Me.nudgeButton1.Size = New System.Drawing.Size(111, 45)
        Me.nudgeButton1.TabIndex = 18
        Me.nudgeButton1.Text = "Nudge"
        Me.nudgeButton1.UseVisualStyleBackColor = False
        '
        'nudgeButton2
        '
        Me.nudgeButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudgeButton2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudgeButton2.Location = New System.Drawing.Point(254, 465)
        Me.nudgeButton2.Name = "nudgeButton2"
        Me.nudgeButton2.Size = New System.Drawing.Size(113, 45)
        Me.nudgeButton2.TabIndex = 19
        Me.nudgeButton2.Text = "Nudge"
        Me.nudgeButton2.UseVisualStyleBackColor = False
        '
        'nudgeButton3
        '
        Me.nudgeButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudgeButton3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudgeButton3.Location = New System.Drawing.Point(396, 465)
        Me.nudgeButton3.Name = "nudgeButton3"
        Me.nudgeButton3.Size = New System.Drawing.Size(111, 45)
        Me.nudgeButton3.TabIndex = 20
        Me.nudgeButton3.Text = "Nudge"
        Me.nudgeButton3.UseVisualStyleBackColor = False
        '
        'creditsButton
        '
        Me.creditsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditsButton.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditsButton.Location = New System.Drawing.Point(101, 523)
        Me.creditsButton.Name = "creditsButton"
        Me.creditsButton.Size = New System.Drawing.Size(75, 78)
        Me.creditsButton.TabIndex = 21
        Me.creditsButton.Text = "Insert 10p"
        Me.creditsButton.UseVisualStyleBackColor = False
        '
        'reelImageLow3
        '
        Me.reelImageLow3.BackColor = System.Drawing.Color.Transparent
        Me.reelImageLow3.Image = Global.WindowsApplication7.My.Resources.Resources._2
        Me.reelImageLow3.InitialImage = Nothing
        Me.reelImageLow3.Location = New System.Drawing.Point(436, 348)
        Me.reelImageLow3.Name = "reelImageLow3"
        Me.reelImageLow3.Size = New System.Drawing.Size(36, 36)
        Me.reelImageLow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageLow3.TabIndex = 17
        Me.reelImageLow3.TabStop = False
        '
        'reelImageLow2
        '
        Me.reelImageLow2.BackColor = System.Drawing.Color.Transparent
        Me.reelImageLow2.Image = Global.WindowsApplication7.My.Resources.Resources._2
        Me.reelImageLow2.InitialImage = Nothing
        Me.reelImageLow2.Location = New System.Drawing.Point(293, 348)
        Me.reelImageLow2.Name = "reelImageLow2"
        Me.reelImageLow2.Size = New System.Drawing.Size(36, 36)
        Me.reelImageLow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageLow2.TabIndex = 16
        Me.reelImageLow2.TabStop = False
        '
        'reelImageLow1
        '
        Me.reelImageLow1.BackColor = System.Drawing.Color.Transparent
        Me.reelImageLow1.Image = Global.WindowsApplication7.My.Resources.Resources._2
        Me.reelImageLow1.InitialImage = Nothing
        Me.reelImageLow1.Location = New System.Drawing.Point(147, 348)
        Me.reelImageLow1.Name = "reelImageLow1"
        Me.reelImageLow1.Size = New System.Drawing.Size(36, 36)
        Me.reelImageLow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageLow1.TabIndex = 15
        Me.reelImageLow1.TabStop = False
        '
        'reelImageTop3
        '
        Me.reelImageTop3.BackColor = System.Drawing.Color.Transparent
        Me.reelImageTop3.Image = Global.WindowsApplication7.My.Resources.Resources._6
        Me.reelImageTop3.Location = New System.Drawing.Point(436, 230)
        Me.reelImageTop3.Name = "reelImageTop3"
        Me.reelImageTop3.Size = New System.Drawing.Size(36, 36)
        Me.reelImageTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageTop3.TabIndex = 14
        Me.reelImageTop3.TabStop = False
        '
        'reelImageTop2
        '
        Me.reelImageTop2.BackColor = System.Drawing.Color.Transparent
        Me.reelImageTop2.Image = Global.WindowsApplication7.My.Resources.Resources._6
        Me.reelImageTop2.Location = New System.Drawing.Point(293, 230)
        Me.reelImageTop2.Name = "reelImageTop2"
        Me.reelImageTop2.Size = New System.Drawing.Size(36, 36)
        Me.reelImageTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageTop2.TabIndex = 13
        Me.reelImageTop2.TabStop = False
        '
        'reelImageTop1
        '
        Me.reelImageTop1.BackColor = System.Drawing.Color.Transparent
        Me.reelImageTop1.Image = Global.WindowsApplication7.My.Resources.Resources._6
        Me.reelImageTop1.InitialImage = Nothing
        Me.reelImageTop1.Location = New System.Drawing.Point(147, 230)
        Me.reelImageTop1.Name = "reelImageTop1"
        Me.reelImageTop1.Size = New System.Drawing.Size(36, 36)
        Me.reelImageTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImageTop1.TabIndex = 12
        Me.reelImageTop1.TabStop = False
        '
        'reelImage3
        '
        Me.reelImage3.BackColor = System.Drawing.Color.Transparent
        Me.reelImage3.Image = Global.WindowsApplication7.My.Resources.Resources._1
        Me.reelImage3.Location = New System.Drawing.Point(421, 272)
        Me.reelImage3.Name = "reelImage3"
        Me.reelImage3.Size = New System.Drawing.Size(70, 70)
        Me.reelImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImage3.TabIndex = 11
        Me.reelImage3.TabStop = False
        '
        'reelImage2
        '
        Me.reelImage2.BackColor = System.Drawing.Color.Transparent
        Me.reelImage2.Image = Global.WindowsApplication7.My.Resources.Resources._1
        Me.reelImage2.Location = New System.Drawing.Point(277, 272)
        Me.reelImage2.Name = "reelImage2"
        Me.reelImage2.Size = New System.Drawing.Size(70, 70)
        Me.reelImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImage2.TabIndex = 10
        Me.reelImage2.TabStop = False
        '
        'reelImage1
        '
        Me.reelImage1.BackColor = System.Drawing.Color.Transparent
        Me.reelImage1.Image = Global.WindowsApplication7.My.Resources.Resources._1
        Me.reelImage1.Location = New System.Drawing.Point(133, 272)
        Me.reelImage1.Name = "reelImage1"
        Me.reelImage1.Size = New System.Drawing.Size(70, 70)
        Me.reelImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reelImage1.TabIndex = 9
        Me.reelImage1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 35
        '
        'stopButton
        '
        Me.stopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stopButton.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopButton.Location = New System.Drawing.Point(331, 522)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 78)
        Me.stopButton.TabIndex = 23
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = False
        '
        'creditsButton2
        '
        Me.creditsButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditsButton2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditsButton2.Location = New System.Drawing.Point(215, 522)
        Me.creditsButton2.Name = "creditsButton2"
        Me.creditsButton2.Size = New System.Drawing.Size(75, 78)
        Me.creditsButton2.TabIndex = 27
        Me.creditsButton2.Text = "Insert £1"
        Me.creditsButton2.UseVisualStyleBackColor = False
        '
        'nudgeImage
        '
        Me.nudgeImage.BackColor = System.Drawing.Color.Transparent
        Me.nudgeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nudgeImage.Image = Global.WindowsApplication7.My.Resources.Resources.nudge
        Me.nudgeImage.Location = New System.Drawing.Point(20, 203)
        Me.nudgeImage.Name = "nudgeImage"
        Me.nudgeImage.Size = New System.Drawing.Size(66, 207)
        Me.nudgeImage.TabIndex = 28
        Me.nudgeImage.TabStop = False
        '
        'holdImage
        '
        Me.holdImage.BackColor = System.Drawing.Color.Transparent
        Me.holdImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.holdImage.Image = Global.WindowsApplication7.My.Resources.Resources.nudge
        Me.holdImage.Location = New System.Drawing.Point(528, 203)
        Me.holdImage.Name = "holdImage"
        Me.holdImage.Size = New System.Drawing.Size(65, 202)
        Me.holdImage.TabIndex = 29
        Me.holdImage.TabStop = False
        '
        'BonusBox1
        '
        Me.BonusBox1.BackColor = System.Drawing.Color.Transparent
        Me.BonusBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BonusBox1.Image = Global.WindowsApplication7.My.Resources.Resources.bon
        Me.BonusBox1.Location = New System.Drawing.Point(12, 43)
        Me.BonusBox1.Name = "BonusBox1"
        Me.BonusBox1.Size = New System.Drawing.Size(374, 98)
        Me.BonusBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BonusBox1.TabIndex = 30
        Me.BonusBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication7.My.Resources.Resources.background122
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 612)
        Me.Controls.Add(Me.BonusBox1)
        Me.Controls.Add(Me.holdImage)
        Me.Controls.Add(Me.nudgeImage)
        Me.Controls.Add(Me.creditsButton2)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.creditsButton)
        Me.Controls.Add(Me.nudgeButton3)
        Me.Controls.Add(Me.nudgeButton2)
        Me.Controls.Add(Me.nudgeButton1)
        Me.Controls.Add(Me.reelImageLow3)
        Me.Controls.Add(Me.reelImageLow2)
        Me.Controls.Add(Me.reelImageLow1)
        Me.Controls.Add(Me.reelImageTop3)
        Me.Controls.Add(Me.reelImageTop2)
        Me.Controls.Add(Me.reelImageTop1)
        Me.Controls.Add(Me.reelImage3)
        Me.Controls.Add(Me.reelImage2)
        Me.Controls.Add(Me.reelImage1)
        Me.Controls.Add(Me.creditLabel)
        Me.Controls.Add(Me.bankLabel)
        Me.Controls.Add(Me.spinButton)
        Me.Controls.Add(Me.holdButton3)
        Me.Controls.Add(Me.holdButton2)
        Me.Controls.Add(Me.holdButton1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Fruit Machine"
        CType(Me.reelImageLow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImageLow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImageLow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImageTop3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImageTop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImageTop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reelImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudgeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.holdImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents holdButton1 As System.Windows.Forms.Button
    Friend WithEvents holdButton2 As System.Windows.Forms.Button
    Friend WithEvents holdButton3 As System.Windows.Forms.Button
    Friend WithEvents spinButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bankLabel As Label
    Friend WithEvents creditLabel As Label
    Friend WithEvents reelImage1 As PictureBox
    Friend WithEvents reelImage2 As PictureBox
    Friend WithEvents reelImage3 As PictureBox
    Friend WithEvents reelImageTop1 As PictureBox
    Friend WithEvents reelImageTop2 As PictureBox
    Friend WithEvents reelImageTop3 As PictureBox
    Friend WithEvents reelImageLow1 As PictureBox
    Friend WithEvents reelImageLow2 As PictureBox
    Friend WithEvents reelImageLow3 As PictureBox
    Friend WithEvents nudgeButton1 As Button
    Friend WithEvents nudgeButton2 As Button
    Friend WithEvents nudgeButton3 As Button
    Friend WithEvents creditsButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents stopButton As Button
    Friend WithEvents creditsButton2 As Button
    Friend WithEvents nudgeImage As PictureBox
    Friend WithEvents holdImage As PictureBox
    Friend WithEvents BonusBox1 As PictureBox
End Class
