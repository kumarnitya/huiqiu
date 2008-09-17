/* JavaScript Virtual Keyboard (ATM-style numpad variant), version 2.7
 * (compressed with ESC: http://www.saltstorm.net/depo/esc/)
 *
 * Copyright (C) 2006-2008 Dmitriy Khudorozhkov (mailto:dmitrykhudorozhkov@yahoo.com)
 *
 * This software is provided "as-is", without any express or implied warranty.
 * In no event will the author be held liable for any damages arising from the
 * use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 */

function VATMpad($a,$b,$c,$d,$e,$f,$g,$h,$i,$j,$k,$l,$m,$n){return this.$0h($a,$b,$c,$d,$e,$f,$g,$h,$i,$j,$k,$l,$m,$n);};VATMpad.kbArray=[];VATMpad.prototype={$o:function($p,$q,$r){return($p.attachEvent?$p.attachEvent("on"+$q,$r):(($p.addEventListener)?$p.addEventListener($q,$r,false):null));},$s:function($t){function getColor($u,$v,$w){if(/rgb\((\d+),\s(\d+),\s(\d+)\)/.exec($u)){switch($v){case 1:return parseInt(RegExp.$1,10);case 2:return parseInt(RegExp.$2,10);case 3:return parseInt(RegExp.$3,10);default:return 0;}}else return $u.length==4?parseInt($u.substr($v,1)+$u.substr($v,1),16):parseInt($u.substr($w,2),16);};function getR($x){return getColor($x,1,1);};function getG($x){return getColor($x,2,3);};function getB($x){return getColor($x,3,5);};var el=$t.time?$t:($t.company&&$t.company.time?$t.company:null);if(el){el.time=0;clearInterval(el.timer);};var $y=this;var $z=$y.fontcolor,$A=$y.keycolor,$B=$y.bordercolor;if($t.dead)$z=$y.deadcolor;if((($t.innerHTML=="Shift")&&$y.Shift)||(($t.innerHTML=="Caps")&&$y.Caps)||(($t.innerHTML=="AltGr")&&$y.AltGr))$A=$y.lic;var fr=getR($z),fg=getG($z),fb=getB($z);var kr=getR($A),kg=getG($A),kb=getB($A);var br=getR($B),bg=getG($B),bb=getB($B);var $C=getR($y.cfc),$D=getG($y.cfc),$E=getB($y.cfc);var $F=getR($y.cbg),$G=getG($y.cbg),$H=getB($y.cbg);var $I=getR($y.cbr),$J=getG($y.cbr),$K=getB($y.cbr);var $L=function(){function dec2hex($M){var $N="0123456789ABCDEF";var a=$M%16;var b=($M-a)/16;return $N.charAt(b)+$N.charAt(a)+"";};$t.time=!$t.time?10:($t.time-1);function calc_color($O,end){return(end -($t.time/10)*(end -$O));};var $P=calc_color($C,fr),$Q=calc_color($D,fg),$R=calc_color($E,fb);var $S=calc_color($F,kr),$T=calc_color($G,kg),$U=calc_color($H,kb);var $V=calc_color($I,br),$W=calc_color($J,bg),$X=calc_color($K,bb);$t.style.color="#"+dec2hex($P)+dec2hex($Q)+dec2hex($R);$t.style.borderColor="#"+dec2hex($V)+dec2hex($W)+dec2hex($X);$t.style.backgroundColor="#"+dec2hex($S)+dec2hex($T)+dec2hex($U);if(!$t.time){clearInterval($t.timer);return;}};$L();$t.timer=window.setInterval($L,50);},$Y:function($Z,top,$00,$01,$02,$03,$h,$f,$04,$d,$05,$06,$07){var os=$Z.style;if(top)os.top=top;if($00)os.left=$00;if($01)os.width=$01;if($02)os.height=$02;if($03)os.position=$03;if($h)os.border="1px solid "+$h;if($f)os.backgroundColor=$f;os.textAlign="center";if($04)os.lineHeight=$04;if($d)os.fontSize=$d;os.fontWeight=$05||"bold";if($06)os.paddingLeft=$06;if($07)os.paddingRight=$07;},$08:function(parent,id,top,$00,$01,$02,$h,$f,$04,$d,$05,$06,$07){var $09=this.Cntr.id+id;var $0a=document.getElementById($09);var $0b=$0a?$0a.parentNode:document.createElement("DIV");this.$Y($0b,top,$00,$01,$02,"absolute");var $0c=$0a||document.createElement("DIV");$0b.appendChild($0c);parent.appendChild($0b);this.$Y($0c,"","","",$04,"relative",$h,$f,$04,$d,$05,$06,$07);$0c.id=$09;if(!$0a)this.$o($0c,'mouseup',this.$0H);return $0c;},$0d:function($Z){return($Z&&$Z.parentNode)?parseFloat($Z.parentNode.offsetLeft):0;},$0e:function($Z){return($Z&&$Z.parentNode)?parseFloat($Z.parentNode.offsetTop):0;},$0f:function($Z){return($Z&&$Z.parentNode)?parseFloat($Z.parentNode.offsetWidth):0;},$0g:function($Z){return($Z&&$Z.parentNode)?parseFloat($Z.parentNode.offsetHeight):0;},$0h:function($a,$b,$c,$d,$e,$f,$g,$h,$i,$j,$k,$l,$m,$n){var $0a=(this.Cntr!=undefined),ct=$0a?this.Cntr:document.getElementById($a);var $0i=($d&&($d!=this.fontsize));this.$0L=((typeof($b)=="function")&&(($b.length==1)||($b.length==2)))?$b:(this.$0L||null);var ff=$c||this.fontname||"";var fs=$d||this.fontsize||"14px";var fc=$e||this.fontcolor||"#000";var bg=$f||this.bgcolor||"#FFF";var kc=$g||this.keycolor||"#FFF";var bc=$h||this.bordercolor||"#777";this.cfc=$j||this.cfc||"#CC3300";this.cbg=$k||this.cbg||"#FF9966";this.cbr=$l||this.cbr||"#CC3300";this.sc=($i==undefined)?((this.sc==undefined)?false:this.sc):$i;this.gap=($n!=undefined)?($n?1:-1):(this.gap||1);this.fontname=ff,this.fontsize=fs,this.fontcolor=fc;this.bgcolor=bg,this.keycolor=kc,this.bordercolor=bc;if(!$0a){this.Cntr=ct,this.LastKey=null;VATMpad.kbArray[$a]=this;};var kb=$0a?ct.childNodes[0]:document.createElement("DIV");if(!$0a){ct.appendChild(kb);ct.style.display="block";ct.style.zIndex=999;if($m)ct.style.position="relative";else{ct.style.position="absolute";var $0j=0,$0k=ct;if($0k.offsetParent){while($0k.offsetParent){$0j+=$0k.offsetLeft;$0k=$0k.offsetParent;}}else if($0k.x)$0j+=$0k.x;var $0l=0;$0k=ct;if($0k.offsetParent){while($0k.offsetParent){$0l+=$0k.offsetTop;$0k=$0k.offsetParent;}}else if($0k.y)$0l+=$0k.y;ct.style.top=$0l+"px",ct.style.left=$0j+"px";};kb.style.position="relative";kb.style.top="0px",kb.style.left="0px";};kb.style.border="1px solid "+bc;var $0m=$0a?kb.childNodes[0]:document.createElement("DIV"),ks=$0m.style;if(!$0a){kb.appendChild($0m);ks.position="relative";ks.width="1px";ks.cursor="default";};this.$o($0m,"selectstart",function(event){return false;});this.$o($0m,"mousedown",function(event){if(event.preventDefault)event.preventDefault();return false;});ks.fontFamily=ff,ks.backgroundColor=bg;if(!$0a||$0i){ks.width=this.$0n($a,$0m);ks.height=(this.$0e(this.LastKey)+this.$0g(this.LastKey)+this.gap)+"px";};return this;},$0n:function($a,parent){var c="center",n="normal",$0o=this.gap;var fs=this.fontsize,kc=this.keycolor,bc=this.bordercolor;var $0p=parseFloat(fs)/14.0,$0q=Math.floor(25.0*$0p);var cp=String($0q)+"px",lh=String(Math.floor($0q-2.0))+"px";var $0r=$0o+"px";var $0s=this.$08(parent,"___pad_7",$0o+"px",$0r,cp,cp,bc,kc,lh,fs);$0s.innerHTML="7";var $0t=String(this.$0d($0s)+this.$0f($0s)+$0o)+"px";var $0u=this.$08(parent,"___pad_8",$0o+"px",$0t,cp,cp,bc,kc,lh,fs);$0u.innerHTML="8";var $0v=String(this.$0d($0u)+this.$0f($0u)+$0o)+"px";var $0w=this.$08(parent,"___pad_9",$0o+"px",$0v,cp,cp,bc,kc,lh,fs);$0w.innerHTML="9";var $0x=this.$0g($0w),$0y=(this.$0e($0w)+$0x+$0o)+"px";$0y=(this.$0e($0s)+$0x+$0o)+"px";var $0z=this.$08(parent,"___pad_4",$0y,$0r,cp,cp,bc,kc,lh,fs);$0z.innerHTML="4";var $0A=this.$08(parent,"___pad_5",$0y,$0t,cp,cp,bc,kc,lh,fs);$0A.innerHTML="5";var $0B=this.$08(parent,"___pad_6",$0y,$0v,cp,cp,bc,kc,lh,fs);$0B.innerHTML="6";$0y=(this.$0e($0z)+$0x+$0o)+"px";var $0C=this.$08(parent,"___pad_1",$0y,$0r,cp,cp,bc,kc,lh,fs);$0C.innerHTML="1";var $0D=this.$08(parent,"___pad_2",$0y,$0t,cp,cp,bc,kc,lh,fs);$0D.innerHTML="2";var $0E=this.$08(parent,"___pad_3",$0y,$0v,cp,cp,bc,kc,lh,fs);$0E.innerHTML="3";$0y=(this.$0e($0C)+$0x+$0o)+"px";var $0F=this.$08(parent,"___pad_0",$0y,$0r,cp,cp,bc,kc,lh,fs);$0F.innerHTML="0";var $0G=this.$08(parent,"___pad_period",$0y,$0t,String(2*$0q+$0o)+"px",cp,bc,kc,lh,parseFloat(fs)*0.9,n);$0G.innerHTML="Enter";this.LastKey=$0G;return String(this.$0d($0w)+this.$0f($0w)+$0o)+"px";},$0H:function(event){var e=event||window.event;var $t=e.srcElement||e.target;var $a=$t.id.substring(0,$t.id.indexOf("___"));var $0I=VATMpad.kbArray[$a];if($0I.sc)$0I.$s($t);if($0I.$0L)$0I.$0L($t.innerHTML,$0I.Cntr.id);},SetParameters:function(){var l=arguments.length;if(!l||(l%2!=0))return false;var p0,p1,p2,p3,p4,p5,p6,p7,p8,p9,$0J;while(--l>0){var $0K=arguments[l];switch(arguments[l-1]){case "callback":p0=((typeof($0K)=="function")&&(($0K.length==1)||($0K.length==2)))?$0K:this.$0L;break;case "font-name":p1=$0K;break;case "font-size":p2=$0K;break;case "font-color":p3=$0K;break;case "base-color":p4=$0K;break;case "key-color":p5=$0K;break;case "border-color":p6=$0K;break;case "show-click":p7=$0K;break;case "click-font-color":p8=$0K;break;case "click-key-color":p9=$0K;break;case "click-border-color":$0J=$0K;break;default:break;};l-=1;};this.$0h(this.Cntr.id,p0,p1,p2,p3,p4,p5,p6,p7,p8,p9,$0J);return true;},Show:function($0K){var ct=this.Cntr.style;ct.display=(($0K==undefined)||($0K==true))?"block":(($0K==false)?"none":ct.display);}};

