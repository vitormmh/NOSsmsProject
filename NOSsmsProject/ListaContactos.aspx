<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaContactos.aspx.cs" Inherits="NOSsmsProject.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Criar nova Lista para enviar campanhas</h3>
      <div class ="container">
            <div class ="row">
                <div class="col-lg-12">
                    <form action"" style="width:550px; margin:auto">
                    <div class="form-group">
                           <asp:textbox class="form-control"  type="text" id="Textbox1" runat="server"/>
                      </div>        
                     <div class="form-group">
                             <asp:textbox class="form-control"  type="text" id="Textbox2" runat="server"/>
                        
                       </div>
                         <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Criar Lista" OnClick="Button1_Click" />
                                        <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Criar Lista" OnClick="Button2_Click" />

                        </form>
                    </div>
                </div>
          </div>

</asp:Content>
