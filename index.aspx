<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BDFFP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/app.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div id="content">
                <br />
               
                
                <h1 class="text-center">One page Supplier Information</h1>
                <br />
                <div class="row">
                    <div class="col-xs-3 col-md-3">
                        <div class="thumbnail">

                            <div class="radio-inline">
                                <asp:Label ID="Label3" runat="server" Text="Database"></asp:Label>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                    <asp:ListItem Text="Scotland" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="Ireland" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Moloney and Kelly" Value="2"></asp:ListItem>
                                </asp:RadioButtonList>
                            </div>

                        </div>
                    </div>
                    <div class="col-xs-9 col-md-9">
                        <div class="thumbnail">
                            <asp:Label ID="Label9" runat="server" Text="Supplier Code" CssClass="auto-style109"></asp:Label>
                            <div class="ui-widget">
                                <label for="TextBox11">Supplier Code:</label><asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            </div>
                            <asp:Button ID="Button10" runat="server" Text="Search" OnClick="Button10_Click" />
                        </div>
                    </div>
                </div>
                <br />
                <h3>Location</h3>
                <div class="row">
                    <div class="col-xs-3 col-md-3">
                        <table class="thumbnail">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" BorderColor="White" ReadOnly="True" BorderStyle="None"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" BorderStyle="None"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" BorderStyle="None"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true" BorderStyle="None"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Height="22px" BorderStyle="None"></asp:TextBox>
                                </td>
                            </tr>

                        </table>

                    </div>
                    <div class="col-xs-9 col-md-9">
                        <iframe id="myiFrame" class="thumbnail" runat="server" width="100%"></iframe>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4 col-lg-4">
                    </div>
                    <br />
                    <asp:Label ID="Label21" runat="server" Text="There are no coordinates inserted for this supplier" Visible="false"></asp:Label>
                    <table>
                        <tr>
                            <td class="auto-style99"></td>
                        </tr>
                    </table>
                    <div class="table-responsive">
                        <table id="Table5" runat="server" class="auto-style22" align="center">
                            <tr>
                                <td class="auto-style92">
                                    <br />
                                    <h3>Contracts</h3>
                                    <br />
                                    <a href="" runat="server" id="mylink"></a>
                                    <br />
                                    <br />

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style25">&nbsp;</td>
                            </tr>
                        </table>
                    </div>
                    <br />
                    <h3>Descriptions</h3>
                    <br />
                    <asp:LinkButton ID="Button1" CssClass="btn btn-default btn-lg" runat="server" Visible="false" OnClick="Button1_Click">Show Descriptions In All Languages</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" CssClass="btn btn-default btn-lg" runat="server" Visible="false" OnClick="LinkButton1_Click">Hide Descriptions For All Languages</asp:LinkButton>
                   <div class="panel-group" id="accordion">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">English Description</a>
                                </h4>
                            </div>
                            <div id="collapse1" runat="server" class="panel-collapse collapse in">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse2">French Description</a>
                                </h4>
                            </div>
                            <div id="collapse2" runat="server" class="panel-collapse collapse">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">Italian Description</a>
                                </h4>
                            </div>
                            <div id="collapse3" runat="server" class="panel-collapse collapse">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">German Description</a>
                                </h4>
                            </div>
                            <div id="Div1" runat="server" class="panel-collapse collapse">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">Italian Description</a>
                                </h4>
                            </div>
                            <div id="Div2" runat="server" class="panel-collapse collapse">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">Spanish Description</a>
                                </h4>
                            </div>
                            <div id="Div3" runat="server" class="panel-collapse collapse">
                                <div class="panel-body"></div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <h3>Pictures</h3>
                    <br />
                    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                        <!-- Indicators -->
                        <ol class="carousel-indicators"></ol>
                        <!-- Wrapper for slides -->
                        <div class="carousel-inner"></div>
                        <!-- Controls -->
                        <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </a>
                        <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                        </a>
                    </div>
                    <br />
                    <h3>Rates</h3>
                    <br />
                    <asp:GridView ID="GridView3" CssClass="table col-md-12 col-sm-10 table-hover" runat="server" AllowPaging="true" PagerSettings-PreviousPageText="Previous"
                        OnPageIndexChanging="GridView3_PageIndexChanging">
                        <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="10" />

                    </asp:GridView>
                    <asp:GridView ID="GridView1" CssClass="table col-md-12 col-sm-10 table-hover " runat="server" AllowPaging="true" OnPageIndexChanging="GridView1_PageIndexChanging">
                        <PagerSettings Mode="NumericFirstLast" Position="Bottom" PageButtonCount="10" />
                    </asp:GridView>
                </div>
            </div>
        </div>
        <!-- Latest compiled and minified JavaScript -->
        <script>
            $(document).ready(function () {
                for (var i = 0; i < testArray.length; i++) {
                    $('<div class="item"><img src="' + testArray[i] + '"><div class="carousel-caption"></div>   </div>').appendTo('.carousel-inner');
                    $('<li data-target="#carousel-example-generic" data-slide-to="' + i + '"></li>').appendTo('.carousel-indicators')

                }
                $('.item').first().addClass('active');
                $('.carousel-indicators > li').first().addClass('active');
                $('#carousel-example-generic').carousel();
            });
        </script>
        <script>
          var availableTags = [ <%= SuggestionList %>];
                $("#<%= TextBox11.ClientID %>").autocomplete({
                    source: availableTags,
                    max: 10, // Limit the autocomplete options that will show
                    minLength: 3, // Will only autocomplete when there are 3 or more letters
                    select: function (event, ui) {
                        event.preventDefault();
                        var selectedArr = ui.item.value.split("-");
                        $("#<%= TextBox11.ClientID %>").val(selectedArr[0]);
                    }
                });

            $(document).ready(function () {
                var availableTags = [ <%= SuggestionList %>];
                $("#<%= TextBox11.ClientID %>").autocomplete({
                    source: availableTags,
                    max: 10, // Limit the autocomplete options that will show
                    minLength: 3, // Will only autocomplete when there are 3 or more letters
                    select: function (event, ui) {
                        event.preventDefault();
                        var selectedArr = ui.item.value.split("-");
                        $("#<%= TextBox11.ClientID %>").val(selectedArr[0]);
                    }
                });
            });
        </script>
    </form>
</body>
</html>
