﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>

<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <title>Coding Challenge VTEX</title>
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link rel="stylesheet" href="Content/bootstrap.css"/>
    <link rel="stylesheet" href="Content/main.css"/>
</head>
<body>
    <div class="container">
      <div class="row">
        <h1>Dev Shop</h1>
      </div>

      <div class="row">
        <h2>Add a developer</h2>
        <form id="form1" runat="server" class="form-inline" role="form">
          <div class="form-group">
            <input type="text" placeholder="GitHub Username" class="form-control" />
          </div>
          <div class="form-group">
            <input type="text" placeholder="Price" class="form-control" />
          </div>
          <button type="submit" class="btn btn-success">Add</button>
        </form>
      </div>

      <div class="cart row">
        <h2>Cart</h2>
        <table class="table">
          <thead>
            <tr>
              <th>Username</th>
              <th>Price</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            <tr class="product">
              <td>brenoc</td>
              <td>$224</td>
              <td><button class="btn btn-danger pull-right">Remove</button></td>
            </tr>
            <tr class="product">
              <td>firstdoit</td>
              <td>$416</td>
              <td><button class="btn btn-danger pull-right">Remove</button></td>
            </tr>
          </tbody>
        </table>
      </div>

      <div class="totalizer row">
        <div class="col-sm-5">
          <div class="row">
            <table class="table">
              <tbody>
                <tr class="total">
                  <td>Total</td>
                  <td>$640</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>

    </div> <!-- /container -->

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="Scripts/jquery-1.11.2.min.js"><\/script>')</script>

    <script src="Scripts/bootstrap.js"></script>
    <!-- <script src="script/main.js"></script> -->

</body>
</html>
