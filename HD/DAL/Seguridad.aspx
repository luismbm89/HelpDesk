<%@ Page Title="" Language="C#" MasterPageFile="~/DAL/Site.Master" AutoEventWireup="true" CodeBehind="Seguridad.aspx.cs" Inherits="HD.DAL.Seguridad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
      <li><i class="ace-icon fa fa-home home-icon"></i>&nbsp;<a href = "default.aspx"> Inicio </a></li><li class="active"><i class="ace-icon fa fa-toggle-off"></i>&nbsp;Seguridad</li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
							<div class="col-xs-12">
								<!-- PAGE CONTENT BEGINS -->
								<div class="form-horizontal" role="form">
									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1"> Clave </label>
										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtClave" TextMode="Password" autofocus="true" CssClass="form-control" placeholder="Clave"/>
										</div>
									</div>
									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1"> LLave </label>
										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtLlave" TextMode="Password"  autofocus="true" CssClass="form-control" placeholder="LLave"/>
										</div>
									</div>
									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1"> Clave Encriptada </label>
										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtClaveEncriptada" autofocus="true" CssClass="form-control" placeholder="Clave Encriptada"/>
										</div>
									</div>
                                    
									<div class="form-group">
                                        	<label class="col-sm-1 control-label" for="form-field-1-1"> </label>
										<div class="col-sm-3">
                                            <asp:LinkButton ID="btnEncriptar" runat="server" Width="80px" CssClass="btn btn-app btn-grey btn-xs radius-4" OnClick="btnEncriptar_Click">
<i class="ace-icon fa fa-lock bigger-160"></i> Encriptar
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="btnDesencriptar" runat="server" Width="100px" Height="60px" CssClass="btn btn-app  btn-danger btn-xs radius-4" OnClick="btnDesencriptar_Click">
<i class="ace-icon fa fa-unlock bigger-160"></i><p style="font-size:15px"> Desencriptar</p>
                                            </asp:LinkButton>

										</div>
									</div>
                                    </div>
                                </div>
        </div>
</asp:Content>
