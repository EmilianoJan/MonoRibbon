Imports System.Windows.Forms

Namespace RibbonComponents
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RibbonPanelP
        'Inherits System.Windows.Forms.UserControl
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(247, 150)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(3, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(241, 124)
            Me.Panel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Location = New System.Drawing.Point(3, 130)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(241, 20)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Label1"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'RibbonPanelP
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "RibbonPanelP"
            Me.Size = New System.Drawing.Size(247, 150)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
    End Class
End Namespace
