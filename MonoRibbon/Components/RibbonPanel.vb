
Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.Drawing.Design
Imports System.Drawing
Imports System.Windows.Forms

Namespace RibbonComponents
    <Designer(GetType(MyUserControlDesignerB))>
    Public Class RibbonPanelP : Inherits UserControl

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Sets or gets the text show in the panel text")>
        Public Property PanelText As String
            Get
                Return textBack
            End Get
            Set(value As String)
                textBack = value
                Label1.Text = value
            End Set
        End Property
        Dim textBack As String


        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Sets or gets the BackColor of the panel")>
        Public Property PanelBackColor As Color
            Get
                Return PanelBackColorB
            End Get
            Set(value As Color)
                PanelBackColorB = value
                Label1.BackColor = PanelBackColorB
                TableLayoutPanel1.BackColor = PanelBackColorB
            End Set
        End Property
        Dim PanelBackColorB As Color

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Sets or gets the BackColor of the panel component area.")>
        Public Property ComponentAreaBackColor As Color
            Get
                Return PanelWindowBackColorB
            End Get
            Set(value As Color)
                PanelWindowBackColorB = value
                Panel1.BackColor = PanelWindowBackColorB
            End Set
        End Property
        Dim PanelWindowBackColorB As Color


        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Label properties of de panel.")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property Label As Label
            Get
                Return Label1
            End Get
            Set(value As Label)

            End Set
        End Property

        '<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        'Public ReadOnly Property ContentsPanel As Panel
        '    Get
        '        Return Panel1
        '    End Get
        'End Property

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property ContentsPanel As Panel
            Get
                Return Panel1
            End Get
            Set(value As Panel)
                If IsNothing(value) = False Then
                    Panel1 = value
                End If
            End Set
        End Property

        Private Sub RibbonPanelP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'If IsNothing(Me.ContentsPanel) = True Then
            '    InitializeComponent()
            '    TypeDescriptor.AddAttributes(Me.ContentsPanel, New DesignerAttribute(GetType(MyPanelDesigner)))
            'End If
            '
            'MyBase.New()
            'InitializeComponent()
            'Me.ResumeLayout(True)
            'Me.Update()
            'TypeDescriptor.AddAttributes(Me.ContentsPanel, New DesignerAttribute(GetType(MyPanelDesigner)))

        End Sub

        Public Sub New()
            MyBase.New()
            InitializeComponent()
            Me.ResumeLayout(True)
            Me.Update()
            'TypeDescriptor.AddAttributes(Me.ContentsPanel, New DesignerAttribute(GetType(MyPanelDesigner)))
            Me.Dock = DockStyle.Left
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub
    End Class

    Public Class MyUserControlDesignerB
        Inherits ParentControlDesigner

        Public Overrides Sub Initialize(ByVal component As IComponent)
            MyBase.Initialize(component)
            'Dim contentsPanel = (CType(Me.Control, RibbonPanelP)).ContentsPanel
            Dim objeto As RibbonPanelP = Me.Control
            Dim contentsPanel = objeto.ContentsPanel
            Me.EnableDesignMode(contentsPanel, "ContentsPanel")
            objeto.Dock = DockStyle.Left
        End Sub

        Public Overrides Function CanParent(ByVal control As Control) As Boolean
            Return False
        End Function

        Protected Overrides Sub OnDragOver(ByVal de As DragEventArgs)
            de.Effect = DragDropEffects.None
        End Sub

        Protected Overrides Function CreateToolCore(ByVal tool As ToolboxItem, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal hasLocation As Boolean, ByVal hasSize As Boolean) As IComponent()
            Return Nothing
        End Function
    End Class

    Public Class MyPanelDesigner
        Inherits ParentControlDesigner

        Public Overrides ReadOnly Property SelectionRules As SelectionRules
            Get
                Dim selectionRulesb As SelectionRules = MyBase.SelectionRules
                selectionRulesb = selectionRulesb And Not SelectionRules.AllSizeable
                Return selectionRulesb
            End Get
        End Property

        Protected Overrides Sub PostFilterAttributes(ByVal attributes As IDictionary)
            MyBase.PostFilterAttributes(attributes)
            attributes(GetType(DockingAttribute)) = New DockingAttribute(DockingBehavior.Never)
        End Sub

        Protected Overrides Sub PostFilterProperties(ByVal properties As IDictionary)
            MyBase.PostFilterProperties(properties)
            Dim propertiesToRemove = New String() {"Dock", "Anchor", "Size", "Location", "Width", "Height", "MinimumSize", "MaximumSize", "AutoSize", "AutoSizeMode", "Visible", "Enabled"}

            For Each item In propertiesToRemove
                If properties.Contains(item) Then properties(item) = TypeDescriptor.CreateProperty(Me.Component.[GetType](), CType(properties(item), PropertyDescriptor), New BrowsableAttribute(False))
            Next
        End Sub
    End Class
End Namespace
