﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindrose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.lblNoOfColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudNoOfColumns = New instat.ucrNud()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrWindRoseSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(260, 45)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(69, 13)
        Me.lblXVariable.TabIndex = 1
        Me.lblXVariable.Text = "Wind Speed:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(260, 93)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(80, 13)
        Me.lblYVariable.TabIndex = 3
        Me.lblYVariable.Text = "Wind Direction:"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(260, 140)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(37, 13)
        Me.lblFacet.TabIndex = 5
        Me.lblFacet.Text = "Facet:"
        '
        'lblNoOfColumns
        '
        Me.lblNoOfColumns.AutoSize = True
        Me.lblNoOfColumns.Location = New System.Drawing.Point(260, 194)
        Me.lblNoOfColumns.Name = "lblNoOfColumns"
        Me.lblNoOfColumns.Size = New System.Drawing.Size(79, 13)
        Me.lblNoOfColumns.TabIndex = 7
        Me.lblNoOfColumns.Text = "No of Columns:"
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(260, 155)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 218)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(251, 24)
        Me.ucrSaveGraph.TabIndex = 9
        '
        'ucrNudNoOfColumns
        '
        Me.ucrNudNoOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfColumns.Location = New System.Drawing.Point(345, 191)
        Me.ucrNudNoOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfColumns.Name = "ucrNudNoOfColumns"
        Me.ucrNudNoOfColumns.Size = New System.Drawing.Size(35, 20)
        Me.ucrNudNoOfColumns.TabIndex = 8
        Me.ucrNudNoOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(260, 108)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.TabIndex = 4
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(260, 60)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.TabIndex = 2
        '
        'ucrWindRoseSelector
        '
        Me.ucrWindRoseSelector.bShowHiddenColumns = False
        Me.ucrWindRoseSelector.bUseCurrentFilter = True
        Me.ucrWindRoseSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrWindRoseSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrWindRoseSelector.Name = "ucrWindRoseSelector"
        Me.ucrWindRoseSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrWindRoseSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 248)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 307)
        Me.Controls.Add(Me.ucrReceiverFacet)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblNoOfColumns)
        Me.Controls.Add(Me.ucrNudNoOfColumns)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrWindRoseSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrWindRoseSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblFacet As Label
    Friend WithEvents lblNoOfColumns As Label
    Friend WithEvents ucrNudNoOfColumns As ucrNud
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
End Class
