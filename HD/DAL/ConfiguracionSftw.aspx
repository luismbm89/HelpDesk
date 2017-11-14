<%@ Page Title="" Language="C#" MasterPageFile="~/DAL/Site.Master" AutoEventWireup="true" CodeBehind="ConfiguracionSftw.aspx.cs" Inherits="HD.DAL.ConfiguracionSftw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        .file-upload {
    display: inline-block;
    overflow: hidden;
    font-family: Arial;
    color: black;
    border-radius: 6px;
    -moz-border-radius: 6px;
    cursor: pointer;
    text-shadow: #000 1px 1px 2px;
    -webkit-border-radius: 6px;
}

.file-upload:hover {
}

/* The button size */
.file-upload {
}

.file-upload, .file-upload span {
}

.file-upload input {
            font-size: 11px;
            font-weight: bold;
            /* Loses tab index in webkit if width is set to 0 */
            opacity: 0;
            filter: alpha(opacity=0);
}

.file-upload strong {
            font: normal 12px Tahoma,sans-serif;
}

.file-upload span {
    
            display: inline-block;
            /* Adjust button text vertical alignment */
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
      <li><i class="ace-icon fa fa-home home-icon"></i>&nbsp;<a href = "default.aspx"> Inicio </a></li><li class="active"><i class="ace-icon fa fa-wrench"></i>&nbsp;Configuración del Sistema</li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
							<div class="col-xs-12">
								<!-- PAGE CONTENT BEGINS -->
								<div class="form-horizontal" role="form">

									

								</div>
</div>
</div>
    <div class="row">
										<div class="col-sm-3">
											<div class="widget-box">
												<div class="widget-header" style="text-align:center">
													<h4 class="widget-title">Configuración Base de Datos</h4>
												</div>

												<div class="widget-body" style="text-align:center">
													<div class="widget-main form-horizontal">
														
									<div class="form-group">
										<label class="control-label" for="form-field-1" style="font-weight:700"> Servidor </label>
                                        <asp:TextBox runat="server" ID="txtServidor" autofocus="true" CssClass="" placeholder="Servidor"/>
									</div>
                                                        <div class="form-group">
										<label class="control-label" for="form-field-1-1" style="font-weight:700"> BD </label>
                                            <asp:TextBox runat="server" ID="txtBD" CssClass="" placeholder="BD"/>
									</div>

									<div class="form-group">
										<label class="control-label" for="form-field-1-1" style="font-weight:700"> Usuario</label>
                                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="" placeholder="Usuario"/>
									</div>

									<div class="form-group">
										<label class="control-label" for="form-field-1-1" style="font-weight:700"> Clave</label>
                                            <asp:TextBox runat="server" ID="txtPassword" CssClass="" placeholder="Clave"/>
									</div>

									<div class="form-group">
                                        	<label class=" control-label" for="form-field-1-1" style="font-weight:700"> </label>
										<div class="">
                                            <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn btn-app btn-grey btn-xs radius-4" OnClick="btnSave_Click">
<i class="ace-icon fa fa-floppy-o bigger-160"></i> Guardar
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="btnCancelar" runat="server" CssClass="btn btn-app  btn-danger btn-xs radius-4" OnClick="btnCancelar_Click">
<i class="ace-icon fa fa-close bigger-160"></i> Cancelar
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-app btn-grey btn-xs radius-4" OnClick="LinkButton3_Click">
<i class="ace-icon fa fa-connectdevelop bigger-160"></i> Test
                                            </asp:LinkButton>

										</div>
									</div>
													</div>
												</div>
											</div>
										</div>
        
										<div class="col-sm-3">
											<div class="widget-box">
												<div class="widget-header" style="text-align:center">
													<h4 class="widget-title">Configuración Sistema</h4>
												</div>

												<div class="widget-body" style="text-align:center">
													<div class="widget-main">
														
														
									<div class="form-group">
										<label class="control-label" for="form-field-1" style="font-weight:700"> Título </label>
                                        <asp:TextBox runat="server" ID="txtTitulo" autofocus="true" CssClass="" placeholder="Título"/>
									</div>
														
									<div class="form-group">
										<label class="control-label" for="form-field-1" style="font-weight:700"> Empresa </label>
                                        <asp:TextBox runat="server" ID="txtEmpresa" autofocus="true" CssClass="" placeholder="Empresa"/>
									</div>
														
									<div class="form-group">
                                        <div style="color:#999;" ><label class="file-upload">
    <span><strong><asp:Label ID="HazClick" runat="server" Text="Logo"></asp:Label></strong></span> 
    <asp:FileUpload ID="FileUpload1" runat="server" accept=".png" >
    </asp:FileUpload>
</label></div>
									</div>
														
									<div class="form-group">
                                        <div style="color:#999;" ><label class="file-upload">
    <span><strong><asp:Label ID="Label1" runat="server" Text="Isotipo"></asp:Label></strong></span> 
    <asp:FileUpload ID="FileUpload2" runat="server" accept=".png" >
    </asp:FileUpload>
</label></div>
									</div>

									<div class="form-group">
                                        	<label class=" control-label" for="form-field-1-1" style="font-weight:700"> </label>
										<div class="">
                                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-app btn-grey btn-xs radius-4" OnClick="LinkButton1_Click">
<i class="ace-icon fa fa-floppy-o bigger-160"></i> Guardar
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-app  btn-danger btn-xs radius-4" OnClick="btnCancelar_Click">
<i class="ace-icon fa fa-close bigger-160"></i> Cancelar
                                            </asp:LinkButton>

										</div>
									</div>
													</div>
												</div>
											</div>
										</div>
</div>
    
    <div class="row">
</div>
</asp:Content>
