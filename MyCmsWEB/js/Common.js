﻿function getTargetElement(evt) {
    var elem
    if (evt.target) {
        elem = (evt.target.nodeType == 3) ? evt.target.parentNode : evt.target
    }
    else {
        elem = evt.srcElement
    }
    return elem
}

var lastD = null;
function Change(evt, tablename) {
    $("#" + tablename).find('input[name*="select"][type="checkbox"]').attr("checked", false);
    evt = (evt) ? evt : ((window.event) ? window.event : " ");
    if (evt == " ") {
        return;
    }
    var obj = getTargetElement(evt);
    var hasTreeNode = false;
    if (obj.tagName) {
        if (obj.tagName == "INPUT" && obj.type == "checkbox") {
            if (lastD) lastD.checked = false
            lastD = obj;
            obj.checked = true;
        }
    }
}
//判断是否有选择的行
function DeleteConfirm(tablename, showmessage) {
    var ret = false;
    if ($("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').length != 1) {
        layer.msg(showmessage, 2, 8);
        ret = false;
    }
    else {
        //var ret = false;
        //layer.confirm('信息框演示三', function (index) {
        //    ret = true;
        //    layer.close(index);
        //},"删除提醒");
        ret = confirm("确定要删除吗？");
    }
    return ret;
}
function DeleteConfirm(tablename, showmessage,showmessage2) {
    var ret = false;
    if ($("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').length != 1) {
        layer.msg(showmessage, 2, 8);
        ret = false;
    }
    else {
        ret = confirm(showmessage2);
    }
    return ret;
}
function DeleteConfirmOne($tr, showmessage) {
    
}

function CheckSelected(tablename, showmessage) {
    var ret = false;
    if ($("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').length != 1) {
        layer.msg(showmessage, 2, 8);
        ret = false;
    }
    else {
        ret =true;
    }
    return ret;
}

function CheckSelectedAndConfirm(tablename, showmessage,showmessage2) {
    var ret = false;
    if ($("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').length != 1) {
        layer.msg(showmessage, 2, 8);
        ret = false;
    }
    else {
        ret = confirm(showmessage2);
    }
    return ret;
}
function UpdateConfirm(tablename, showmessage, pagetitle, pagesrc, pagewidth, pageheight) {
    if ($("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').length != 1) {
        layer.msg(showmessage, 2, 8);
        return false;
    }
    else {
        var key = $("#" + tablename).find('input[name*="select"][type="checkbox"]:checked').val();
        ShowIframe(pagetitle, pagesrc+key, pagewidth, pageheight);
        return false;
    }
}
function UpdateConfirmOne($tr, pagetitle, pagesrc, pagewidth, pageheight) {
    var key = $tr.parents("tr").find('input[name*="select"][type="checkbox"]').val();
    ShowIframe(pagetitle, pagesrc + key, pagewidth, pageheight);
    return false;
}
function ShowIframe(pagetitle, pagesrc, pagewidth, pageheight) {
   $.layer({
        type: 2,
        fix: true,
        title: pagetitle,
        //offset:['80px','160px'],
        maxmin: true,
        iframe: { src: pagesrc },
        area: [pagewidth, pageheight]
    });
}
function closeLayer(obj) {
    var allLayerIfms = $(".xubox_iframe", window.parent.document);//所有layer层 (可能嵌套打开了多个layer)
    var len = allLayerIfms.length;
    for (var i = 0; i < len; i++) {
        var layerIfm = allLayerIfms[i];
        if ($(layerIfm).contents().find($(obj)).length == 1)//该layer是关闭按钮所在的layer 
        {
            //找到layer右上角的X按钮
            var closeBtn = $(layerIfm).parent().find("a[class='xubox_close xulayer_png32 xubox_close0']");
            //模拟点击
            closeBtn.get(0).click();
            break;
        }
    }
}


//资质附件删除
function delFileUpload($file, pageurl) {
    var attachID = $file.attr("data-value");
    var senddata = '{ attachID: "' + attachID + '"}';
    $prent_file = $file.parent(".MultiFile-label");
    ajaxExistTwo(pageurl + "/DeleteQAttachByID", senddata, $prent_file, "资质附件删除成功", "资质附件删除成功");
    var e = $file[0];
    if (e && e.stopPropagation)
        //因此它支持W3C的stopPropagation()方法
        e.stopPropagation();
    else
        //否则，我们需要使用IE的方式来取消事件冒泡 
        window.event.cancelBubble = true;
}


//ajax封装
function ajaxExistTwo(pageurl, senddata, $file, showmessage, errormessage) {
    $.ajax({
        type: 'POST',//使用get方法访问后台
        dataType: 'json',//返回json格式的数据
        contentType: "application/json;charset=utf-8",
        url: pageurl,//要访问的后台地址
        data: senddata,//要发送的数据
        error: function (errorThrown) {//请求错误 时执行的方法 
            alert("error!" + errorThrown.error);
        },
        success: function (data) {
            if (data.d == true) {
                layer.msg(showmessage, 2, 9);
                $file.remove();
            }
        }
    });
}


//资质文件下载或查看
function showOrdown($div) {
    var exten = $div.attr("data-value1");
    var quali_id = $div.attr("data-value2");
    var attach_id = $div.attr("data-value3");
    var path = $div.attr("data-value4");
    var all_exten = "png|jpg|jpeg|gif|bmp";
    if (all_exten.indexOf(exten) != -1) {
        window.open("/Pub/ShowPicture.aspx?quali_id=" + quali_id + "&attach_id=" + attach_id);
    } else {
        window.open(path);
    }
}


//获取get值
function getQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = decodeURI(window.location.search).substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

Date.prototype.Format = function (fmt)
{ //author: meizz 
    var o = {
        "M+": this.getMonth() + 1, //月份 
        "d+": this.getDate(), //日 
        "h+": this.getHours(), //小时 
        "m+": this.getMinutes(), //分 
        "s+": this.getSeconds(), //秒 
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
        "S": this.getMilliseconds() //毫秒 
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}