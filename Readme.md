<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1470)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.Designer.cs](./CS/WindowsApplication1/Form1.Designer.cs) (VB: [Form1.Designer.vb](./VB/WindowsApplication1/Form1.Designer.vb))
<!-- default file list end -->
# How to modify a scale tickmark display value via the Multiplier property


<p>Please refer to the Q207196 issue in the Support Center for more information.<br />
Sometimes business requirements need to show large values like millions, billions, etc. in a compact manner, without using all numbers.<br />
To accomplish this task, the MajorTickmark.Multiplier property can be used, for example:</p><p>this.arcScaleComponent1.MajorTickmark.Multiplier = 1E-06F;</p><p>Please play with the attached example for more information.</p>

<br/>


