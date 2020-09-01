<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>muay tay</title>
</head>
<body dir="rtl">
    <div>
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
        <h1>טופס הרשמה</h1>
        <pre>אנא מלאו את כל השדות הבאים:</pre>
        <form action="" id="register" name="register" method="post" >
            שם פרטי:
            <input type="text" name="firstName" id="firstname" />
            <br />
            שם משפחה:
            <input type="text" name="lastName" id="lastname"/>
            <br />
            מין:
            <input type="radio" class="gender" name="gender" value="male"/> זכר
            <input type="radio"  class="gender" name="gender" value="female"/> נקבה
            <input type="radio"  class="gender" name="gender" value="other"/> אחר
            <br />
            אימייל:
            <input type="text" name="email" id="email"/>
            <br />
            סיסמה:
            <input type="password" id="password" name="password" />
            <br />
            טלפון:
            <input type="text" name="phone" />
            <br />
            <input type="submit" name="submit" value="הרשם" />
            
        </form>
    </div>
</body>
</html>
