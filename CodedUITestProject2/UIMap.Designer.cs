﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Dieser Code wurde vom Coded UI-Test-Generator generiert.
//      Version: 14.0.0.0
//
//      In dieser Datei sind spezialisierte Klassen definiert, die in einem
//      Coded UI-Test verwendet werden.
//      In dieser Datei können die erforderlichen Anpassungen vorgenommen werden.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Positivtest 2
        /// </summary>
        public void bieri()
        {
            #region Variable Declarations
            WinEdit uINameEdit = this.UIDebugWindow.UIItemWindow.UIM120LB2FS17ListItem.UINameEdit;
            WpfListItem uISystemDynamicExpandoListItem = this.UIMainWindowWindow.UILb_vermietungList.UISystemDynamicExpandoListItem;
            WpfText uIItem6102017110000AMText = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem2Row.UIItem6102017110000AMCell.UIItem6102017110000AMText;
            WinList uIElementansichtList = this.UIDebugWindow.UIShellViewWindow.UIShellViewClient.UIElementansichtList;
            WpfText uIItem610201760000PMText = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem2Row.UIItem610201760000PMCell.UIItem610201760000PMText;
            WpfButton uIHauptmenuButton = this.UIMainWindowWindow.UIItemCustom.UIHauptmenuButton;
            #endregion

            // Doppelklicken "Name" Textfeld
            Mouse.DoubleClick(uINameEdit, new Point(45, 3));

            // Klicken "System.Dynamic.ExpandoObject" Listenelement
            Mouse.Click(uISystemDynamicExpandoListItem, new Point(187, 16));

            // Klicken "6/10/2017 11:00:00 AM" Bezeichnung
            Mouse.Click(uIItem6102017110000AMText, new Point(7, 10));

            // Klicken "6/10/2017 11:00:00 AM" Bezeichnung
            Mouse.Click(uIItem6102017110000AMText, new Point(7, 10));

            // "{Back}{NumPad8}" in "Elementansicht" Listenfeld eingeben
            Keyboard.SendKeys(uIElementansichtList, this.bieriParams.UIElementansichtListSendKeys, ModifierKeys.None);

            // Klicken "6/10/2017 6:00:00 PM" Bezeichnung
            Mouse.Click(uIItem610201760000PMText, new Point(3, 12));

            // Klicken "6/10/2017 6:00:00 PM" Bezeichnung
            Mouse.Click(uIItem610201760000PMText, new Point(5, 10));

            // "{Delete}{NumPad8}{Enter}" in "Elementansicht" Listenfeld eingeben
            Keyboard.SendKeys(uIElementansichtList, this.bieriParams.UIElementansichtListSendKeys1, ModifierKeys.None);

            // Klicken "Hauptmenu" Schaltfläche
            Mouse.Click(uIHauptmenuButton, new Point(299, 11));
        }
        
        /// <summary>
        /// exit
        /// </summary>
        public void exit()
        {
            #region Variable Declarations
            WinButton uISchließenButton = this.UIMainWindowWindow1.UISchließenButton;
            #endregion

            // Klicken "Schließen" Schaltfläche
            Mouse.Click(uISchließenButton, new Point(25, 25));
        }
        
        #region Properties
        public virtual bieriParams bieriParams
        {
            get
            {
                if ((this.mbieriParams == null))
                {
                    this.mbieriParams = new bieriParams();
                }
                return this.mbieriParams;
            }
        }
        
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIUseUIAutomationToTesWindow UIUseUIAutomationToTesWindow
        {
            get
            {
                if ((this.mUIUseUIAutomationToTesWindow == null))
                {
                    this.mUIUseUIAutomationToTesWindow = new UIUseUIAutomationToTesWindow();
                }
                return this.mUIUseUIAutomationToTesWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private bieriParams mbieriParams;
        
        private UIDebugWindow mUIDebugWindow;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIUseUIAutomationToTesWindow mUIUseUIAutomationToTesWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// An "bieri" zu übergebende Parameter
    /// </summary>
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class bieriParams
    {
        
        #region Fields
        /// <summary>
        /// "{Back}{NumPad8}" in "Elementansicht" Listenfeld eingeben
        /// </summary>
        public string UIElementansichtListSendKeys = "{Back}{NumPad8}";
        
        /// <summary>
        /// "{Delete}{NumPad8}{Enter}" in "Elementansicht" Listenfeld eingeben
        /// </summary>
        public string UIElementansichtListSendKeys1 = "{Delete}{NumPad8}{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIShellViewWindow UIShellViewWindow
        {
            get
            {
                if ((this.mUIShellViewWindow == null))
                {
                    this.mUIShellViewWindow = new UIShellViewWindow(this);
                }
                return this.mUIShellViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIShellViewWindow mUIShellViewWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Elementansicht";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIM120LB2FS17ListItem UIM120LB2FS17ListItem
        {
            get
            {
                if ((this.mUIM120LB2FS17ListItem == null))
                {
                    this.mUIM120LB2FS17ListItem = new UIM120LB2FS17ListItem(this);
                }
                return this.mUIM120LB2FS17ListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIM120LB2FS17ListItem mUIM120LB2FS17ListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIM120LB2FS17ListItem : WinListItem
    {
        
        public UIM120LB2FS17ListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinListItem.PropertyNames.Name] = "M120-LB2-FS17";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Suchkriterien
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIShellViewWindow : WinWindow
    {
        
        public UIShellViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShellView";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SHELLDLL_DefView";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIShellViewClient UIShellViewClient
        {
            get
            {
                if ((this.mUIShellViewClient == null))
                {
                    this.mUIShellViewClient = new UIShellViewClient(this);
                }
                return this.mUIShellViewClient;
            }
        }
        #endregion
        
        #region Fields
        private UIShellViewClient mUIShellViewClient;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIShellViewClient : WinClient
    {
        
        public UIShellViewClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinControl.PropertyNames.Name] = "Shellordneransicht";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinList UIElementansichtList
        {
            get
            {
                if ((this.mUIElementansichtList == null))
                {
                    this.mUIElementansichtList = new WinList(this);
                    #region Suchkriterien
                    this.mUIElementansichtList.SearchProperties[WinList.PropertyNames.Name] = "Elementansicht";
                    this.mUIElementansichtList.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUIElementansichtList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIElementansichtList;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UILb_vermietungList UILb_vermietungList
        {
            get
            {
                if ((this.mUILb_vermietungList == null))
                {
                    this.mUILb_vermietungList = new UILb_vermietungList(this);
                }
                return this.mUILb_vermietungList;
            }
        }
        
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private UILb_vermietungList mUILb_vermietungList;
        
        private UIItemCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UILb_vermietungList : WpfList
    {
        
        public UILb_vermietungList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "lb_vermietung";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfListItem UISystemDynamicExpandoListItem
        {
            get
            {
                if ((this.mUISystemDynamicExpandoListItem == null))
                {
                    this.mUISystemDynamicExpandoListItem = new WpfListItem(this);
                    #region Suchkriterien
                    this.mUISystemDynamicExpandoListItem.SearchProperties[WpfListItem.PropertyNames.Name] = "System.Dynamic.ExpandoObject";
                    this.mUISystemDynamicExpandoListItem.SearchProperties[WpfListItem.PropertyNames.Instance] = "2";
                    this.mUISystemDynamicExpandoListItem.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISystemDynamicExpandoListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mUISystemDynamicExpandoListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItemCustom : WpfCustom
    {
        
        public UIItemCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.VermietungEinzelansicht";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIDg_vermietungTable UIDg_vermietungTable
        {
            get
            {
                if ((this.mUIDg_vermietungTable == null))
                {
                    this.mUIDg_vermietungTable = new UIDg_vermietungTable(this);
                }
                return this.mUIDg_vermietungTable;
            }
        }
        
        public WpfButton UIHauptmenuButton
        {
            get
            {
                if ((this.mUIHauptmenuButton == null))
                {
                    this.mUIHauptmenuButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUIHauptmenuButton.SearchProperties[WpfButton.PropertyNames.Name] = "Hauptmenu";
                    this.mUIHauptmenuButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIHauptmenuButton;
            }
        }
        #endregion
        
        #region Fields
        private UIDg_vermietungTable mUIDg_vermietungTable;
        
        private WpfButton mUIHauptmenuButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDg_vermietungTable : WpfTable
    {
        
        public UIDg_vermietungTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "dg_vermietung";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIItem2Row UIItem2Row
        {
            get
            {
                if ((this.mUIItem2Row == null))
                {
                    this.mUIItem2Row = new UIItem2Row(this);
                }
                return this.mUIItem2Row;
            }
        }
        #endregion
        
        #region Fields
        private UIItem2Row mUIItem2Row;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem2Row : WpfRow
    {
        
        public UIItem2Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfRow.PropertyNames.Name] = "2";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIItem6102017110000AMCell UIItem6102017110000AMCell
        {
            get
            {
                if ((this.mUIItem6102017110000AMCell == null))
                {
                    this.mUIItem6102017110000AMCell = new UIItem6102017110000AMCell(this);
                }
                return this.mUIItem6102017110000AMCell;
            }
        }
        
        public UIItem610201760000PMCell UIItem610201760000PMCell
        {
            get
            {
                if ((this.mUIItem610201760000PMCell == null))
                {
                    this.mUIItem610201760000PMCell = new UIItem610201760000PMCell(this);
                }
                return this.mUIItem610201760000PMCell;
            }
        }
        #endregion
        
        #region Fields
        private UIItem6102017110000AMCell mUIItem6102017110000AMCell;
        
        private UIItem610201760000PMCell mUIItem610201760000PMCell;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem6102017110000AMCell : WpfCell
    {
        
        public UIItem6102017110000AMCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Start";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfText UIItem6102017110000AMText
        {
            get
            {
                if ((this.mUIItem6102017110000AMText == null))
                {
                    this.mUIItem6102017110000AMText = new WpfText(this);
                    #region Suchkriterien
                    this.mUIItem6102017110000AMText.SearchProperties[WpfText.PropertyNames.Name] = "6/10/2017 11:00:00 AM";
                    this.mUIItem6102017110000AMText.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItem6102017110000AMText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUIItem6102017110000AMText;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem610201760000PMCell : WpfCell
    {
        
        public UIItem610201760000PMCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Ende";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfText UIItem610201760000PMText
        {
            get
            {
                if ((this.mUIItem610201760000PMText == null))
                {
                    this.mUIItem610201760000PMText = new WpfText(this);
                    #region Suchkriterien
                    this.mUIItem610201760000PMText.SearchProperties[WpfText.PropertyNames.Name] = "6/10/2017 6:00:00 PM";
                    this.mUIItem610201760000PMText.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItem610201760000PMText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUIItem610201760000PMText;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIUseUIAutomationToTesWindow : WinWindow
    {
        
        public UIUseUIAutomationToTesWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Use UI Automation To Test Your Code - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Use UI Automation To Test Your Code - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIItemPropertyPage UIItemPropertyPage
        {
            get
            {
                if ((this.mUIItemPropertyPage == null))
                {
                    this.mUIItemPropertyPage = new UIItemPropertyPage(this);
                }
                return this.mUIItemPropertyPage;
            }
        }
        #endregion
        
        #region Fields
        private UIItemPropertyPage mUIItemPropertyPage;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItemPropertyPage : WinControl
    {
        
        public UIItemPropertyPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "PropertyPage";
            this.WindowTitles.Add("Use UI Automation To Test Your Code - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new WinCustom(this);
                    #region Suchkriterien
                    this.mUIItemCustom.WindowTitles.Add("Use UI Automation To Test Your Code - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private WinCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WinButton UISchließenButton
        {
            get
            {
                if ((this.mUISchließenButton == null))
                {
                    this.mUISchließenButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUISchließenButton.SearchProperties[WinButton.PropertyNames.Name] = "Schließen";
                    this.mUISchließenButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISchließenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISchließenButton;
        #endregion
    }
}
