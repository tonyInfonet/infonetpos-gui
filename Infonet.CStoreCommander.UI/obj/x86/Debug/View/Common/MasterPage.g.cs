﻿#pragma checksum "F:\infonetpos\infonetpos-gui\Infonet.CStoreCommander.UI\View\Common\MasterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5BD669452DCA6DBD066466DF6D393DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.Common
{
    partial class MasterPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MasterPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMasterPage_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.Common.MasterPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2SourceDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7CommandDisabled = false;

            private MasterPage_obj1_BindingsTracking bindingsTracking;

            public MasterPage_obj1_Bindings()
            {
                this.bindingsTracking = new MasterPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 34 && columnNumber == 16)
                {
                    isobj2SourceDisabled = true;
                }
                else if (lineNumber == 64 && columnNumber == 28)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 28)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 28)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 78 && columnNumber == 37)
                {
                    isobj7CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\Common\MasterPage.xaml line 32
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 4: // View\Common\MasterPage.xaml line 62
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // View\Common\MasterPage.xaml line 65
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // View\Common\MasterPage.xaml line 49
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // View\Common\MasterPage.xaml line 78
                        this.obj7 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMasterPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Infonet.CStoreCommander.UI.View.Common.MasterPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.Common.MasterPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MasterPageVM(obj.MasterPageVM, phase);
                    }
                }
            }
            private void Update_MasterPageVM(global::Infonet.CStoreCommander.UI.ViewModel.Common.MasterPageVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MasterPageVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MasterPageVM_Background(obj.Background, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MasterPageVM_Time(obj.Time, phase);
                        this.Update_MasterPageVM_Date(obj.Date, phase);
                        this.Update_MasterPageVM_VersionNumber(obj.VersionNumber, phase);
                        this.Update_MasterPageVM_SizeChangedCommand(obj.SizeChangedCommand, phase);
                    }
                }
            }
            private void Update_MasterPageVM_Background(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\Common\MasterPage.xaml line 32
                    if (!isobj2SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj2, obj, null);
                    }
                }
            }
            private void Update_MasterPageVM_Time(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\MasterPage.xaml line 62
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_MasterPageVM_Date(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\MasterPage.xaml line 65
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_MasterPageVM_VersionNumber(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\MasterPage.xaml line 49
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_MasterPageVM_SizeChangedCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Common\MasterPage.xaml line 78
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj7, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MasterPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MasterPage_obj1_Bindings> weakRefToBindingObj; 

                public MasterPage_obj1_BindingsTracking(MasterPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MasterPage_obj1_Bindings>(obj);
                }

                public MasterPage_obj1_Bindings TryGetBindingObject()
                {
                    MasterPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MasterPageVM(null);
                }

                public void PropertyChanged_MasterPageVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MasterPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.Common.MasterPageVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.Common.MasterPageVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_MasterPageVM_Time(obj.Time, DATA_CHANGED);
                                bindings.Update_MasterPageVM_Date(obj.Date, DATA_CHANGED);
                                bindings.Update_MasterPageVM_VersionNumber(obj.VersionNumber, DATA_CHANGED);
                                bindings.Update_MasterPageVM_SizeChangedCommand(obj.SizeChangedCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Time":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MasterPageVM_Time(obj.Time, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Date":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MasterPageVM_Date(obj.Date, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "VersionNumber":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MasterPageVM_VersionNumber(obj.VersionNumber, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SizeChangedCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MasterPageVM_SizeChangedCommand(obj.SizeChangedCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.Common.MasterPageVM cache_MasterPageVM = null;
                public void UpdateChildListeners_MasterPageVM(global::Infonet.CStoreCommander.UI.ViewModel.Common.MasterPageVM obj)
                {
                    if (obj != cache_MasterPageVM)
                    {
                        if (cache_MasterPageVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_MasterPageVM).PropertyChanged -= PropertyChanged_MasterPageVM;
                            cache_MasterPageVM = null;
                        }
                        if (obj != null)
                        {
                            cache_MasterPageVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_MasterPageVM;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // View\Common\MasterPage.xaml line 37
                {
                    this.MasterFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // View\Common\MasterPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MasterPage_obj1_Bindings bindings = new MasterPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
