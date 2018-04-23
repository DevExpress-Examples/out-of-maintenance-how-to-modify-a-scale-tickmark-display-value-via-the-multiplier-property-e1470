Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(12, 12)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(565, 382)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 553, 370)
			Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge1.Name = "cGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}M"
			Me.arcScaleComponent1.MajorTickmark.Multiplier = 1E-06F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
			Me.arcScaleComponent1.MajorTickmark.TextOffset = 22F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 2E+07F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
			Me.arcScaleComponent1.Name = "scale1"
			Me.arcScaleComponent1.RadiusX = 83F
			Me.arcScaleComponent1.RadiusY = 83F
			Me.arcScaleComponent1.StartAngle = -240F
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg1"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style7
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = -25F
			Me.arcScaleNeedleComponent1.Name = "needle1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
			Me.arcScaleNeedleComponent1.StartOffset = -21F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleEffectLayerComponent1.Name = "effect1"
			Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.06F)
			Me.arcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.75]")
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style7
			Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(235F, 110F)
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(589, 406)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
	End Class
End Namespace

