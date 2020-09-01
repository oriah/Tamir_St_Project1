<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>thai gym </title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <style>
        .carousel-inner > .item > img,
        .carousel-inner > .item > a > img {
            width: 40%;
            margin: auto;
        }
    </style>

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
            <li><a href="about.aspx">אודות המועדון</a></li>
        </ul>
    </div>
    <br />
    <br />
    <p>שלום אורח</p>
    <h1 style="text-align:center;">ברוכים הבאים למועדון האגרוף התאילנדי Thai gym</h1>
    <p>פה להכניס תיאור קצר של האתר</p>
    <div class="container">

    
        <div id="myCarousel" class="carousel slide">

            <ol class="carousel-indicators">
                <li class="item1 active"></li>
                <li class="item2"></li>
                <li class="item3"></li>
                <li class="item4"></li>
            </ol>

            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="image1.jpg" alt="gloves" width="460" height="345">
                    <div class="carousel-caption">
                        <h3>Boxing</h3>
                        <p>This is a photo of boxing gloves</p>
                    </div>
                </div>
                <div class="item">
                    <img src="image2.jpg" alt="group" width="460" height="345">
                    <div class="carousel-caption">
                        <h3>Chania</h3>
                        <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
                    </div>
                </div>
                <div class="item">
                    <img src="images/3.jpg" alt="Flower" width="460" height="345">
                    <div class="carousel-caption">
                        <h3>Flowers</h3>
                        <p>Beatiful flowers in Kolymbari, Crete.</p>
                    </div>
                </div>
                <div class="item">
                    <img src="images/4.jpg" alt="Flower" width="460" height="345">
                    <div class="carousel-caption">
                        <h3>Flowers</h3>
                        <p>Beatiful flowers in Kolymbari, Crete.</p>
                    </div>
                </div>
            </div>

            <a class="left carousel-control" href="#myCarousel" role="button">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>

    <br />
    <br />
    <p>טלפון ליצירת קשר: 03-5400000</p>
    <p> 
        אימייל ליצירת קשר:
        <a href="mailto:bloch.hadar22@gmail.com">bloch.hadar22@gmail.com</a>
    </p>

    <script>
    $(document).ready(function(){
        // Activate Carousel
        $("#myCarousel").carousel();

        // Enable Carousel Indicators
        $(".item1").click(function(){
            $("#myCarousel").carousel(0);
        });
        $(".item2").click(function(){
            $("#myCarousel").carousel(1);
        });
        $(".item3").click(function(){
            $("#myCarousel").carousel(2);
        });
        $(".item4").click(function(){
            $("#myCarousel").carousel(3);
        });

        // Enable Carousel Controls
        $(".left").click(function(){
            $("#myCarousel").carousel("prev");
        });
        $(".right").click(function(){
            $("#myCarousel").carousel("next");
        });
    });
        </script>
</body>
</html>
