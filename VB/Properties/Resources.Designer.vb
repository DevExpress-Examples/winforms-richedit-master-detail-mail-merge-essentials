'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System

Namespace RichEditMasterDetailMailMerge.Properties

    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>
        Friend Sub New()
        End Sub

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(RichEditMasterDetailMailMerge.Properties.Resources.resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(RichEditMasterDetailMailMerge.Properties.Resources).Assembly)
                    RichEditMasterDetailMailMerge.Properties.Resources.resourceMan = temp
                End If

                Return RichEditMasterDetailMailMerge.Properties.Resources.resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared Property Culture As Global.System.Globalization.CultureInfo
            Get
                Return RichEditMasterDetailMailMerge.Properties.Resources.resourceCulture
            End Get

            Set(ByVal value As Global.System.Globalization.CultureInfo)
                RichEditMasterDetailMailMerge.Properties.Resources.resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend Shared ReadOnly Property performMailMergeItem_LargeGlyph As System.Drawing.Bitmap
            Get
                Dim obj As Object = RichEditMasterDetailMailMerge.Properties.Resources.ResourceManager.GetObject("performMailMergeItem.LargeGlyph", RichEditMasterDetailMailMerge.Properties.Resources.resourceCulture)
                Return CType((obj), System.Drawing.Bitmap)
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend Shared ReadOnly Property showAllFieldCodesItem_LargeGlyph As System.Drawing.Bitmap
            Get
                Dim obj As Object = RichEditMasterDetailMailMerge.Properties.Resources.ResourceManager.GetObject("showAllFieldCodesItem.LargeGlyph", RichEditMasterDetailMailMerge.Properties.Resources.resourceCulture)
                Return CType((obj), System.Drawing.Bitmap)
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend Shared ReadOnly Property showAllFieldResultsItem_LargeGlyph As System.Drawing.Bitmap
            Get
                Dim obj As Object = RichEditMasterDetailMailMerge.Properties.Resources.ResourceManager.GetObject("showAllFieldResultsItem.LargeGlyph", RichEditMasterDetailMailMerge.Properties.Resources.resourceCulture)
                Return CType((obj), System.Drawing.Bitmap)
            End Get
        End Property
    End Class
End Namespace
