<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>טופס התחברות</title>
</head>
<body dir="rtl">
     <style type="text/css">
        ul.horizontal {list-style-type: none; margin:0; padding:0;}
        ul.horizontal li {display:grid; float:right; }
        ul.horizontal a {width: 60px; text-decoration: none; border: 1px dotted black; padding: 5px; background-color:white; }
    
    </style>

    <div class="menu">
        <ul class="horizontal">
            <li><a href="HomePage.aspx">דף הבית</a></li>
            <li><a href="Register.aspx">הרשמה</a></li>
            <li><a href="Login.aspx">התחברות</a></li>
            <li><a href="">link4</a></li>
            <li><a href="">link5</a></li>
        </ul>
    </div>
    <br />
    <h1>טופס התחברות</h1>
    <p>אנא הכנס אימייל וסיסמה:</p>
    <form action="" id="login" name="login" method="post" >
            אימייל:
            <input type="text" name="email" id="email"/>
            <br />
            סיסמה:
            <input type="password" id="password" name="password" />
            <br />
            <input type="submit" name="submit" value="התחבר" />  
        </form>
    
</body>
</html>
