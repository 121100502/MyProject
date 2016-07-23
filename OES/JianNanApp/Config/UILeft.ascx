<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UILeft.ascx.cs" Inherits="JianNanApp.Config.UILeft" %>
<div id="topUser" class="leftConBorder">
                <div class="userInfo">
                    <dl class="userFaceDl">
                        <dt>
                            <img src="/images/UI/face1s.jpg" width="58" height="58">
                            <dd></dd>
                          </dt>
                    </dl>
                    <ul class="userInforUl">
                        <li>
                            <h1>
                                <asp:Literal ID="litDeptName" runat="server"></asp:Literal>：
                                 <asp:Literal ID="litUserTrueName" runat="server"></asp:Literal>
                            </h1>
                        </li>
                        <li><a href="#">今天是: <%=DateTime.Now.ToString("yyyy-MM-dd") %></a> </li>
                        <li><asp:LinkButton ID="lbtnQuit" runat="server" OnClick="lbtnQuit_Click">我要离开</asp:LinkButton></li>
                        <li><a id="lnkModifyPwd" style="color: #06f" href="#">修改密码</a> </li>
                    </ul>
                </div>
            </div>
            <div class="leftConBorder">
                <div class="leftCon">
                    <div onclick="fa1.toggle();javascript:if (document.getElementById('leftTopBar1').className == 'leftTitOpen') {this.className = 'leftTitClose';} else {this.className = 'leftTitOpen';}"
                        id="leftTopBar1" class="leftTitOpen">
                        系统管理菜单
                    </div>
                    <div id="nav1_mid" class="toolCon" style="height: 100%; overflow: hidden;">
                        <ul class="leftToolUl">
                            <li>
                                <a onclick="showlinkSyschange('linkSys0', 7);" id="linkSys0" class="toolBtn"
                                    href="/default.aspx"
                                    target="lmain">CRM</a>
                            </li>
                        </ul>
                    </div>
                    <div class="leftBottom"></div>
                </div>
            </div>