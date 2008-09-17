/**
Javascript Util Collection
 */


Function.prototype.method = function (name, func) {
    this.prototype[name] = func;
    return this;
};

//��̬���JS�ļ�
function append_js(url,js_file_id)
{
        var obj = $(js_file_id);
        if(obj){
                obj.parentNode.removeChild(obj);
		}
        var newscript = document.createElement("script");
        newscript.type = "text/javascript";
        newscript.src = url;
        newscript.id = js_file_id;
        document.body.appendChild(newscript);
}

//$����ö���
function $(objname){
	return document.getElementById(objname);
}

//��ö���X����
function objPosX(obj){
	var left = 0;
	if (obj.offsetParent) {
		while (obj.offsetParent) {
			left += obj.offsetLeft;
			obj = obj.offsetParent;
		}
	} else if (obj.x) eft += obj.x;
	return left;
}

//��ö���Y����
function objPosY(obj){
	var top = 0;
	if (obj.offsetParent) {
		while (obj.offsetParent) {
			top += obj.offsetTop;
			obj = obj.offsetParent;
		}
	} else if (obj.y) top += obj.y;
	return top;
}