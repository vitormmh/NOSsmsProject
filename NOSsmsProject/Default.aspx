<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NOSsmsProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
        <div class ="container">
            <div class ="row">
                 <div class="col-lg-6">
                            <div class="form-group">
                           <asp:textbox class="form-control"  type="text" id="Textbox1" runat="server"/>
                      </div>        
                     <div class="form-group">
                             <asp:textbox class="form-control"  type="text" id="Textbox2" runat="server"/>
                        
                       </div>
                         <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Criar Lista" OnClick="Button6_Click" />
                            <br />
                            </div>

              

                <div class="col-lg-6">
                    <form action"" style="width:550px; margin:auto">
                        <div class="form-group">
                            <label for="NrTelemovel">Envie SMS </label>
                            <asp:textbox class="form-control" placeholder="Nr Telemovel" type="text" id="nrtelemovel" runat="server"/>
                        </div> 
                        <div class="form-floating">
                                                     
                         <asp:textbox class="form-control" placeholder="Escreva aqui a sua mensagem" id="floatingTextarea" runat="server" Height="158px"></asp:textbox>
                        
                         </div>
                      
                          <div>
                       
                   
                              <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Enviar SMS" OnClick="Button1_Click" />
                    </form>
                </div>
            </div>
        </div>
                        
    </div>

    <div class="row">
        <div class="col-md-4">
           
        </div>
        <div class="col-md-4">
          
        </div>
        <div class="col-md-4">
            
        </div>
    </div>

</asp:Content>
