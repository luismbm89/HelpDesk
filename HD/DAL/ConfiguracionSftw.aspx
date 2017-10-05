<%@ Page Title="" Language="C#" MasterPageFile="~/DAL/Site.Master" AutoEventWireup="true" CodeBehind="ConfiguracionSftw.aspx.cs" Inherits="HD.DAL.ConfiguracionSftw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
      <li><i class="ace-icon fa fa-home home-icon"></i>&nbsp;<a href = "default.aspx"> Inicio </a></li><li class="active"><i class="ace-icon fa fa-wrench"></i>&nbsp;Configuración del Sistema</li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
							<div class="col-xs-12">
								<!-- PAGE CONTENT BEGINS -->
								<div class="form-horizontal" role="form">
									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1"> Servidor </label>

										<div class="col-sm-3">
											
                                            <asp:TextBox runat="server" ID="txtServidor" autofocus="true" CssClass="form-control" placeholder="Servidor"/>
										</div>
									</div>

									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1-1"> BD </label>

										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtBD" CssClass="form-control" placeholder="BD"/>
										</div>
									</div>

									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1-1"> Usuario</label>

										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" placeholder="Usuario"/>
										</div>
									</div>

									<div class="form-group">
										<label class="col-sm-1 control-label" for="form-field-1-1"> Clave</label>

										<div class="col-sm-3">
                                            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" placeholder="Clave"/>
										</div>
									</div>

									<div class="form-group">
                                        	<label class="col-sm-1 control-label" for="form-field-1-1"> </label>
										<div class="col-sm-3">                                            <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn btn-app btn-grey btn-xs radius-4" OnClick="btnSave_Click">
<i class="ace-icon fa fa-floppy-o bigger-160"></i> Guardar
                                            </asp:LinkButton>                                            <asp:LinkButton ID="btnCancelar" runat="server" CssClass="btn btn-app  btn-danger btn-xs radius-4" OnClick="btnSave_Click">
<i class="ace-icon fa fa-close bigger-160"></i> Cancelar
                                            </asp:LinkButton>
										</div>
									</div>

								</div></div>
</div>
</asp:Content>
