using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

using DBLayer;
namespace UCMLCommon
{
    public partial class P_Tran_Task_GRService : UCMLCommon.UCMLWSBPObject
    {
        private DataTable dsBC_Tran_Task;
        private UCMLCommon.UseEntityClass dsBC_Tran_TaskBase;
        public P_Tran_Task_GRService()
        {
            BPOName = "P_Tran_Task_GR";
            LocalResourcePath = "../../../";
            OwnerFlow = "";
            OwnerActivity = "";
            InFlow = false;
            fSystemBPO = false;
            IsH5Page = true;
            IsMobilePage = false;
            fMutiLangugeSupport = false;
            fRegisterBPO = false;
            fEnableConfig = false;
            fFromActivityPermiss = false;
            fTransactionType = TransactionType.tsDB;
            InitializeComponent();
            if (busiAssemblyMode == BusiAssemblyMode.WeiService || busiAssemblyMode == BusiAssemblyMode.SingleWeiService)
            {
               Init();
            }
        }
        public P_Tran_Task_GRService(bool fLocalClass):base(fLocalClass)
        {
            BPOName = "P_Tran_Task_GR";
            LocalResourcePath = "../../../";
            OwnerFlow = "";
            OwnerActivity = "";
            InFlow = false;
            fSystemBPO = false;
            IsH5Page = true;
            IsMobilePage = false;
            fMutiLangugeSupport = false;
            fRegisterBPO = false;
            fEnableConfig = false;
            fFromActivityPermiss = false;
            fTransactionType = TransactionType.tsDB;
            InitializeComponent();
        }
    
      	#region Component Designer generated code
      	
      	//Web ����������������
      	private IContainer components = null;
      			
      	/// <summary>
      	/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
      	/// �˷��������ݡ�
      	/// </summary>
      	private void InitializeComponent()
      	{
      	}
      
      	/// <summary>
      	/// ������������ʹ�õ���Դ��
      	/// </summary>
      	protected override void Dispose( bool disposing )
      	{
      		if(disposing && components != null)
      		{
      			components.Dispose();
      		}
      		base.Dispose(disposing);		
      	}
      	
      	#endregion
       
        public UCMLCommon.BusinessColumn[] BC_Tran_TaskColumn;
        public UCMLCommon.BusinessColumn[] BC_Tran_TaskCondiColumn;
        UCMLCommon.BusinessColumn column;
        /// <summary>
        /// </summary>
        public DataTable BC_Tran_Task
        {
            get
            {
                dsBC_Tran_Task = this.BPODataSet.Tables["BC_Tran_Task"];
                if (dsBC_Tran_Task == null)
                {
                    dsBC_Tran_Task = new DataTable("BC_Tran_Task");
                    this.BPODataSet.Tables.Add(dsBC_Tran_Task);
                }
                return dsBC_Tran_Task;
            }
            set
            {
                dsBC_Tran_Task = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public UCMLCommon.UseEntityClass BC_Tran_TaskBase
        {
            get
            {
                return dsBC_Tran_TaskBase;
            }
            set
            {
                dsBC_Tran_TaskBase = value;
            }
        }
        
        #region ҵ�������ʼ��
        override public void RegisterUseTable()
        {
             BPOName = "P_Tran_Task_GR";
            UseEntityArray = new UCMLCommon.UseEntityClass[1];
            UCMLCommon.UseEntityClass item;
            item = new UCMLCommon.UseEntityClass();
            BC_Tran_TaskBase = item;
            item.TableName = "Tran_Task";
            item.ExtTableName = "";
            item.BCName = "BC_Tran_Task";
            item.dataTable = BC_Tran_Task;
            item.entityType = UCMLCommon.EntityType.MOTIF;
            item.Columns = BC_Tran_TaskColumn;
            item.condiColumns = BC_Tran_TaskCondiColumn;
            item.DBObjectType = typeof(DBLayer.Tran_Task);
            item.DaoType = typeof(DBLayer.Tran_Task);
            item.FieldInfoArray = BC_Tran_TaskColumn;
            item.DBType = UCMLCommon.DBType.MSSQL;
            item.Provider = UCMLCommon.DBProvider.MSSQLNA;
            item.DataOwnerType = (UCMLCommon.DataOwnerType)(0);
            item.DataAccessControlFieldName = "";
            item.CatalogFieldName = "";
            item.CatalogFieldValue = "";
            item.LinkKeyName = "";
            item.LinkKeyType = 46;
            item.PK_COLUMN_NAME = "";
            item.CascadeDeleteMode = 1;
            item.CascadeTableName = "";
            item.CascadeFKName = "";
            item.SelectLastFix = "";
            item.WhereLastFix = "";
            item.IsSODMode = false;
            item.IsReConnectNo = false;
            item.DBConnectionNo = 0;
            item.fTreeGridBC = false;
            item.IsDyColumns = false;
            item.ParentFieldName = "";
            item.fCustomerSQL = false;
            item.CustomerSQLSelect = "";
            item.AllowModifyJION = false;
            item.AllowModifyFK = "";
            item.fNumToString =  false;
            item.PageCount = -1;
            item.fNotReadData = true;
            item.IsRootBC = true;
            item.JoinInfo = new UCMLCommon.UCMLJoinInfo[0];
            item.BusiViewModes = new UCMLCommon.UCMLBusiViewMode[0];
            if (fLoalClass)
                item.BuildDataTableEx();
            if (item.dataTable.Columns.Count==0)
            {
                for ( int i=0; i<item.Columns.Length;i++)
                {
                    item.dataTable.Columns.Add(new DataColumn(item.Columns[i].FieldName, SystemTypeToCSharp(item,item.Columns[i].FieldType)));
                }
            }
            item.OnCustomPrepareCoulmns(FBPODataSet);
            item.fHaveUCMLKey = true;
            item.fIDENTITYKey = false;
            item.BaseKeyField = "Tran_TaskOID";
            UseEntityArray[0] = item;

                AppletLinkArray = new UCMLCommon.UCMLPortal.AppletLinkInfo[1];
                UCMLCommon.UCMLPortal.AppletLinkInfo appletLink = null;
                appletLink = new UCMLCommon.UCMLPortal.AppletLinkInfo();
                appletLink.AppletName = "VC_Tran_Task_GR";
                appletLink.BCName = "BC_Tran_Task";
                appletLink.Caption = "�����´�";
                appletLink.Pane = "";
                appletLink.ParentField = "";
                appletLink.TreeCaptionField = "";
                appletLink.HaveCheck = false;
                appletLink.RootValueMode = 0;
                appletLink.RootValue = "";
                appletLink.VCKind = 163;
                appletLink.fTreeGridMode = false;
                appletLink.fSubTableTreeMode = false;
                appletLink.ImageLink = "";
                appletLink.SubBCs = "";
                appletLink.SubParentFields = "";
                appletLink.SubLabelFields = "";
                appletLink.SubPicFields = "";
                appletLink.SubFKFields = "";
                AppletLinkArray[0] = appletLink;
        }

        protected void getBC_Tran_Task0WhereItemEx(object sender, EventArgs e)
        {
            ((UCMLCommon.WhereItemEventArgs)e).WhereItem=(getBC_Tran_Task0WhereItem());
        }
        protected string getBC_Tran_Task0WhereItem()
        {
//Ȩ�޷�װ
return Permission.SqlStr.getSqlStr(BPOName,loginUserInfo);
                       // ���̹�������
string ret="1=1";
if(this.BusinessParams["InstanceID"]!=null){
    ret="Tran_Task.InstanceID='"+this.BusinessParams["InstanceID"].ToString()+"'";
}
return ret;
        }
        override protected void PreparePropertyList()
        {
            if (PropertyList.Columns.Count==0)
            {
            }
        }
        override protected void ReadPropertyList()
        {
            if (PropertyList.Columns.Count!=0)
            {
            }
        }
        override public void PrepareColumn()
        {
            BC_Tran_TaskColumn = LoadColumnFromXML("BC_Tran_Task");
            if (BC_Tran_TaskColumn == null)
            {
                BC_Tran_TaskColumn = new UCMLCommon.BusinessColumn[37];
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Tran_TaskOID";
                column.fDisplay = false; 
                column.fCanModify = false; 
                column.Pos = 0;
                column.Width = 0;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = false;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[0] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_Created";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 1;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 2;
                column.fGroupBy = false; 
                column.Caption = "��������";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[1] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_LAST_UPD";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 2;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����޸�����";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[2] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_Deleted";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 3;
                column.Width = 0;
                column.FieldType = 20;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��¼ɾ�����";
                column.EditType = "CHECKBOX";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[3] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "PersonName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 4;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[4] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "PostName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 5;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������λ";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[5] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Division";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 6;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[6] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "OrgName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 7;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������λ";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[7] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "TaskName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 8;
                column.Width = 200;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[8] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Remark";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 9;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[9] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "standard";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 10;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��ɱ�׼";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[10] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Start";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 11;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�ƻ���ʼ";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[11] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Finish";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 12;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�ƻ����";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[12] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Important";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 13;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��Ҫ�̶�";
                column.EditType = "INPUT";
                column.CodeTable = "Tran_TaskImportant";
                column.fUseCodeTable = true;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[13] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "DutyPerson";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 14;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[14] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "DutyPersonFK";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 15;
                column.Width = 0;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "���������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[15] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Participants";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 16;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�����ˣ���ѡ��";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[16] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "ParticipantsFK";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 17;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "���������(��ѡ��";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[17] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "CheckPerson";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 18;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�����";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[18] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "CheckPersonFK";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 19;
                column.Width = 0;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[19] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "BusinessState";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 20;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "״̬";
                column.EditType = "INPUT";
                column.CodeTable = "Tran_TaskState";
                column.fUseCodeTable = true;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[20] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "ActualStart";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 21;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "ʵ�ʿ�ʼ";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[21] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "ActualFinish";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 22;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "ʵ�����";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[22] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "ProjectName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 23;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������Ŀ����";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[23] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_CreatedBy";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 24;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�����û�";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[24] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_REPLACEMENT";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 25;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��Ȩ�û�";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[25] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_POSTN";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 26;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������λ";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_PostOID";
                column.LookupDataSet = "UCML_Post";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[26] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_DIVISION";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 27;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "��������";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_OrganizeOID";
                column.LookupDataSet = "UCML_Organize";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[27] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_ORG";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 28;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������֯";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_OrganizeOID";
                column.LookupDataSet = "UCML_Organize";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[28] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_LAST_UPD_BY";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 29;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����޸��û�";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[29] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Pub_Project_FK";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 30;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "������Ŀ";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "Pub_ProjectOID";
                column.LookupDataSet = "Pub_Project";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[30] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "BusinessFlow";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 31;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����״̬";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 5;
                column.CustomSQLColumn = "Dbo.D_getFlowState(Tran_Task.InstanceID,Tran_Task.BusinessState) AS BusinessFlow";
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[31] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "StartFlowFlag";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 32;
                column.Width = 0;
                column.FieldType = 20;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "�����������";
                column.EditType = "CHECKBOX";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[32] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "InstanceID";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 33;
                column.Width = 0;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����ʵ�����";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[33] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "FlowID";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 34;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "���̱��";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[34] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Title";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 35;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "���̱���";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[35] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Operation";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 36;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "����";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 3;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskColumn[36] = column;
            }
            BC_Tran_TaskCondiColumn = new UCMLCommon.BusinessColumn[1];
            column = new UCMLCommon.BusinessColumn();
            column.FieldName = "";
            column.LeftBracket = "";
            column.RightBracket = "";
            column.FieldType = 0;
            column.OperationIndent = "=";
            column.LogicConnect = "AND";
            column.CondiFieldValue = "";
            column.fCondiField = true; 
            column.fIsFunctionValue = false; 
            column.fFreeWhere = true; 
            column.Pos = 37;
            column.getWhereItemHandler += new System.EventHandler(this.getBC_Tran_Task0WhereItemEx);
            BC_Tran_TaskCondiColumn[0] = column;

        }
        #endregion
        /// <summary>
        /// ��ά�����ȡָ�꺯��
        /// </summary>
        public void ReadFromKPISection()
        {
        }

        /// <summary>
        /// ��ά������ָ�꺯��
        /// </summary>
        public void WriteToKPISection()
        {
        }

        /// <summary>
        /// ��ȡ����״̬����
        /// </summary>
        override public void ReadDataFromFlow()
        {
        }

        /// <summary>
        /// ��ȡ����״̬����
        /// </summary>
        override public void ReadDataFromFlowEx()
        {
        }

        /// <summary>
        /// ��������״̬����
        /// </summary>
        override public void SaveDataToFlow()
        {
        }

        /// <summary>
        /// ҵ���ʼ��
        /// </summary>
        override protected void BusinessInit()
        {
            base.BusinessInit();

        }

        /// <summary>
        /// ҵ���ύ����
        /// </summary>
        override protected void AfterBusinessSubmit()
        {


        }

    }
}
