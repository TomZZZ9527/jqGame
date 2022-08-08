var BusinessObject = new UCML.BusinessUnit();
BusinessObject.BPOName = "VC_Tran_TaskMXBtn_ED";
BusinessObject.GloalServiceName = "";
BusinessObject.IsAssemblyToYun = false;
BusinessObject.AgentID = "EMS_New";
BusinessObject.fitWindow =false;
var ShortCutKeyList = [];
var VC_Tran_TaskMX_ED;
var VC_Tran_TaskMX_EDColumns;
var BC_Tran_TaskMXBase;
var BC_Tran_TaskMXColumns;
function onInit()
{
    BC_Tran_TaskMXBase = new UCML.BusinessComponent();
    BC_Tran_TaskMXBase.BusinessObject = BusinessObject;
    BC_Tran_TaskMXBase.TableName = "Tran_TaskMX";
    BC_Tran_TaskMXBase.BCName = "BC_Tran_TaskMX";
    BC_Tran_TaskMXBase.fIDENTITYKey = false;
    BC_Tran_TaskMXBase.AllowModifyJION = false;
    BC_Tran_TaskMXBase.fHaveUCMLKey = true;
    BC_Tran_TaskMXBase.fHaveUCMLKey = false;
    BC_Tran_TaskMXBase.PrimaryKey = "Tran_TaskMXOID";
    BC_Tran_TaskMXBase.loaded = false;
    BC_Tran_TaskMXBase.columns = BC_Tran_TaskMXColumns;
            BC_Tran_TaskMXBase.BPOName = "VC_Tran_TaskMXBtn_ED";
    BC_Tran_TaskMXBase.ChangeOnlyOwnerBy = false;
    BC_Tran_TaskMXBase.EnabledEdit=true;
    BC_Tran_TaskMXBase.EnabledAppend=true;
    BC_Tran_TaskMXBase.EnabledDelete=true;
    BC_Tran_TaskMXBase.RecordOwnerType=0;
    BC_Tran_TaskMXBase.open();

    VC_Tran_TaskMX_ED = new UCML.Edit("VC_Tran_TaskMX_ED");
    VC_Tran_TaskMX_ED.BusinessObject = BusinessObject;
    VC_Tran_TaskMX_ED.dataTable = BC_Tran_TaskMXBase;
    VC_Tran_TaskMX_ED.columns = VC_Tran_TaskMX_EDColumns;
            VC_Tran_TaskMX_ED.enabledEdit=true;
    VC_Tran_TaskMX_ED.haveMenu=true;
    VC_Tran_TaskMX_ED.HiddenID="";
    VC_Tran_TaskMX_ED.fHidden="false";
    VC_Tran_TaskMX_ED.alignHeight="false";
    VC_Tran_TaskMX_ED.alignWidth="true";
    VC_Tran_TaskMX_ED.parentNodeID="";
    VC_Tran_TaskMX_ED.IsJQMPage=false;
    VC_Tran_TaskMX_ED.JQMPageTheme="";



    VC_Tran_TaskMX_ED.open();
}
function VC_Tran_TaskMX_EDExtMenuClick(cmd)
{
}

function VC_Tran_TaskMX_EDmenuready()
{
}
function InitCustomInput()
{
}
function onRender()
{
window.TabStrip_Level_1 = new UCML.TabPanel({el:$("#TabStrip_Level_1"), alignWidth: true, alignHeight: false });

}
function onBeforeOpen()
{


}
function BusinessInit()
{

fn_InitEv();


}

function BeforeSubmit()
{



    return true
}


 function AfterSubmit()
{



}

function CanSubmit()
{
    var result=true
    for ( var i=0;i<this.UseTableList.length;i++)
    {
        result = this.UseTableList[i].Valiate();
        if (result==false) break;
    }


    return result;
}

function BC_Tran_TaskMXOnFieldChange(e)
{
}

function fn_InitEv(){
	fn_feedback()//反馈页面
	//fn_Submit(); //保存反馈信息
	
	
	
	}
function fn_Submit() {
/*
    $("#comment").click(function () {
	BC_Tran_TaskMXBase.Insert();
	BC_Tran_TaskMXBase.setFieldValue("Remark",$('#content').val());
	BC_Tran_TaskMXBase.setFieldValue("OrgName",BC_Tran_TaskBase.getOrgName());
	BC_Tran_TaskMXBase.setFieldValue("PersonName",BC_Tran_TaskBase.getPersonName());
	BC_Tran_TaskMXBase.setFieldValue("DivisionName",BC_Tran_TaskBase.getDivisionName());
	BC_Tran_TaskMXBase.setFieldValue("Tran_Task_FK",getURLParameters("BusinessKeyOID"));
	
	BusinessSubmit();
	
	
    });*/

	

	
}
function fn_feedback(){
	
	$(function () {  
           // var TaskName=BC_Tran_TaskBase.getFieldValue("TaskName");//反馈页面回显任务标题
			//$("#sonTaskName").attr("value",TaskName)
			
			
            for (i = 0; i < BC_Tran_TaskMXBase.getTotalRecordCount(); i++) {  //获取反馈信息
                var Remark = BC_Tran_TaskMXBase.getRowFieldValue(i, "Remark");
                var PersonName = BC_Tran_TaskMXBase.getRowFieldValue(i, "PersonName");
                var OrgName = BC_Tran_TaskMXBase.getRowFieldValue(i, "OrgName");
                var Division = BC_Tran_TaskMXBase.getRowFieldValue(i, "Division");
                var SYS_Created = BC_Tran_TaskMXBase.getRowFieldValue(i, "SYS_Created");
                var OID = BC_Tran_TaskMXBase.getRowFieldValue(i, "Tran_TaskMXOID");
                var ActualFinish = BC_Tran_TaskMXBase.getRowFieldValue(i, "ActualFinish");//完成时间
                var	img="./images/img1.jpg"
                if((BC_Tran_TaskMXBase.getRowFieldValue(i, "PersonName"))=="系统管理员"){
                	var	img="./images/img.jpg"
                	}

              /*  for (j = 0; j < BC_Tran_TaskMXSonBase.getTotalRecordCount(); j++) { 		//获取显示反馈的回复           
                  	if((BC_Tran_TaskMXSonBase.getRowFieldValue(j, "Tran_TaskMX_FK"))==OID){
                		console.log((BC_Tran_TaskMXSonBase.getRowFieldValue(j, "Tran_TaskMX_FK"))+"------------"+OID);
                		console.log((BC_Tran_TaskMXSonBase.getRowFieldValue(j, "Tran_TaskMX_FK"))==OID);
                		var SonRemark = BC_Tran_TaskMXBase.getRowFieldValue(j, "Remark");
                		var Replier = BC_Tran_TaskMXBase.getRowFieldValue(j, "Replier");
                		var ByReplier = BC_Tran_TaskMXBase.getRowFieldValue(j, "ByReplier");
                		var SonreplyBody=[{id:3,img:"",replyName:ByReplier,beReplyName:Replier,content:SonRemark,time:"2017-10-17 11:42:53",
                		           	address:"",osname:"",browse:"谷歌"},];
                		}else{
						var SonreplyBody=[];
                	}
                	
                	};*/
                           
                var arr = [{
                        id: OID,
                        img: img,
                        replyName: PersonName,
                        beReplyName: Remark,
                        content: Remark,
                        time: ActualFinish,
                        address: "111",
                        osname: OrgName,
                        browse: Division,
                        replyBody: []
                    },
                ];
                $(".comment-list").addCommentList({data: arr,add: ""});
            }
	  				
	  


	  });
	  	
	
        var userName = BC_Tran_TaskBase.getPersonName(); //登录名
        var UserOrgNameName = BC_Tran_TaskBase.getOrgName();
        var UserDivisionName = BC_Tran_TaskBase.getDivisionName();
        $("#comment").click(function () { //发表反馈信息
            var obj = new Object();
            obj.img = "./images/img.jpg";
            obj.replyName = userName;
            obj.content = $("#content").val();
            obj.browse = UserDivisionName;
            obj.osname = UserOrgNameName;
            obj.replyBody = "";
            $(".comment-list").addCommentList({data: [],add: obj});
        });
        
        
        
        

    }
function PrepareColumn() 
{
    BC_Tran_TaskMXColumns = new Array();
    objColumn = new Object();
    objColumn.fieldName = "Tran_TaskMXOID";
    objColumn.caption = "主键 ";
    objColumn.length = 0;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = false;
    objColumn.defaultValue = "";
    objColumn.allowModify = false;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_Created";
    objColumn.caption = "创建日期 ";
    objColumn.length = 0;
    objColumn.decLength = 0;
    objColumn.fieldType = "DateTime";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_LAST_UPD";
    objColumn.caption = "最后修改日期 ";
    objColumn.length = 0;
    objColumn.decLength = 0;
    objColumn.fieldType = "DateTime";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_Deleted";
    objColumn.caption = "记录删除标记 ";
    objColumn.length = 0;
    objColumn.decLength = 0;
    objColumn.fieldType = "Boolean";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "PersonName";
    objColumn.caption = "创建人 ";
    objColumn.length = 50;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "PostName";
    objColumn.caption = "创建岗位 ";
    objColumn.length = 50;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "Division";
    objColumn.caption = "创建部门 ";
    objColumn.length = 100;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "OrgName";
    objColumn.caption = "创建单位 ";
    objColumn.length = 100;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "TaskMX_Type";
    objColumn.caption = "类别 ";
    objColumn.length = 50;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "Tran_TaskFeedbackCategory";
    objColumn.isCodeTable = true;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "Remark";
    objColumn.caption = "描述 ";
    objColumn.length = 500;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "FinishState";
    objColumn.caption = "完成状态 ";
    objColumn.length = 50;
    objColumn.decLength = 0;
    objColumn.fieldType = "VarChar";
    objColumn.codeTable = "Tran_TaskFinishState";
    objColumn.isCodeTable = true;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "ActualFinish";
    objColumn.caption = "实际完成时间 ";
    objColumn.length = 0;
    objColumn.decLength = 0;
    objColumn.fieldType = "DateTime";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "";
    objColumn.lookupDataSet = "";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = false;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_CreatedBy";
    objColumn.caption = "创建用户 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_UserOID";
    objColumn.lookupDataSet = "UCML_User";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_REPLACEMENT";
    objColumn.caption = "授权用户 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_UserOID";
    objColumn.lookupDataSet = "UCML_User";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_POSTN";
    objColumn.caption = "所属岗位 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_PostOID";
    objColumn.lookupDataSet = "UCML_Post";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_DIVISION";
    objColumn.caption = "所属部门 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_OrganizeOID";
    objColumn.lookupDataSet = "UCML_Organize";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_ORG";
    objColumn.caption = "所属组织 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_OrganizeOID";
    objColumn.lookupDataSet = "UCML_Organize";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "SYS_LAST_UPD_BY";
    objColumn.caption = "最后修改用户 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "UCML_UserOID";
    objColumn.lookupDataSet = "UCML_User";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    objColumn = new Object();
    objColumn.fieldName = "Tran_Task_FK";
    objColumn.caption = "任务下达 ";
    objColumn.length = 30;
    objColumn.decLength = 0;
    objColumn.fieldType = "UCMLKey";
    objColumn.codeTable = "";
    objColumn.isCodeTable = false;
    objColumn.allowNull = true;
    objColumn.defaultValue = "";
    objColumn.allowModify = true;
    objColumn.foreignKeyField = "";
    objColumn.lookupKeyField = "Tran_TaskOID";
    objColumn.lookupDataSet = "Tran_Task";
    objColumn.lookupResultField = "";
    objColumn.isForeignKey = true;
    objColumn.fieldKind = 0;
    objColumn.isMultiValueField = false;
    objColumn.multiValueTable = "";
    objColumn.isFunctionInitValue = false;
    objColumn.initValueFunc = "";
    objColumn.excelColNo = 0;
    objColumn.IsImageBase64Data = false;
    objColumn.QueryRefColumn = "";
    objColumn.dateTimeFormat = "";
    BC_Tran_TaskMXColumns[BC_Tran_TaskMXColumns.length] = objColumn;

    VC_Tran_TaskMX_EDColumns = new Array();
    objColumn = new Object();
    objColumn.fieldName = "Remark";
    objColumn.caption = "描述";
    objColumn.display = true;
    objColumn.allowModify = true;
    objColumn.width = 210;
    objColumn.isFixColumnValue = false;
    objColumn.fixColumnValue = "";
    objColumn.isCustomerControl = false;
    objColumn.align = "left";
    objColumn.customerControl = "";
    objColumn.controlID = "";
    objColumn.editContrl = "";
    objColumn.PromptText = "";
    objColumn.EditType = "UCML.TextBox";
    objColumn.mutiValueCol = false;
    objColumn.inputTip = "";
    VC_Tran_TaskMX_EDColumns[VC_Tran_TaskMX_EDColumns.length] = objColumn;

    ResetColumns(VC_Tran_TaskMX_EDColumns, "VC_Tran_TaskMX_ED");
    PrepareExColumn();
}
