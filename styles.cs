* {box-sizing:border-box}

:root{
    --pink: rgb(255, 92, 92);
}


*{
    margin:0; padding:0;
    box-sizing: border-box;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    outline: none; border: none;
    text-decoration: none;
    text-transform: none;
    transition: .2s linear;
}


html{
    font-size: 65%;
    scroll-behavior: smooth;
    scroll-padding-top: 6em;
    overflow-x: hidden;
}

.heading{
    text-align: center;
    font-size: 4rem;
    color: #333;
    padding: 1rem;
    margin: 2rem 0;
    background: rgba(255, 82, 51, 0.05);
}


.heading span{
    color: var(--pink);
}


header{
    position: fixed;
    top: 0; left: 0; right: 0;
    background: #ffffff;
    padding: 2rem 9%;
    display: flex;
    align-items: center;
    justify-content: space-between;
    z-index: 1000;
    box-shadow: 0.5rem 1rem rgba(0, 0, 0, .1);
}


header .logo{
    font-size: 3rem;
    color: #333;
    font-weight: bolder;
}

header .navbar a{
    font-size: 1.5rem;
    padding:0 1.5rem;
    color: #666;
}


header .navbar a:hover{
    color: var(--pink);
}


header #toggler{
    display: none;
}


header .fa-bars{
    font-size: 3rem;
    color: #333;
    border-radius: 5rem;
    padding: 5rem 1.5rem;
    cursor: pointer;
    border: 1rem solid rgba(0, 0, 0, 3);
    display: none;
}



@media (max-width:991px){
    html{
        font-size: 55%;
    }

    header{
        padding: 2rem;
    }
}



@media (max-width:768px){
    
    header .fa-bars{
        display: block;
    }

    header .navbar{
        position: absolute;
        top: 0%; right: 0%; left: 0%;
        background: #eee;
        border-top: .1rem solid rgba(0, 0, 0, .1);
        clip-path: polygon(0 0, 100% 0, 100% 0, 0 0);
    }

    header #toggler:checked ~ .navbar{
        clip-path: polygon(0 0, 100% 0, 100% 100%, 0 100%);;
    }

    header .navbar a{
        margin: 1.5rem;
        padding: 1.5rem;
        background: #ffffff;
        border: 1rem solid rgba(0, 0, 0, 1);
        display: block;
    }
}

@media (max-width:450px){
    html{
        font-size: 50%;
    }
    .heading{
        font-size: 3rem;
    }
}


.home {
    display: flex;
    align-items: center;
    background-image: url("imagens/sinergiasbannerr.png");
    background-repeat: no-repeat;
    background-size: cover;
    background-position: left top;
    height: 600px;
    color: #fdf4f1;
    padding: 20px;
}

.home .conteudo{
    max-width: 50rem;
}

.home .conteudo h3{
    font-size: 10rem;
    color: #f7e3e3;
    text-align: center;
}

.home .conteudo p{
    font-size: 2rem;
    color:  #f7e3e3;
    padding: 1rem 0;
    line-height: 1.5;
    text-align: center;
    background-color: rgba(190, 101, 101, 0.9);
    border-radius: 30px;
    display: inline-block;
    padding-left: 0.7cm;
    padding-right: 0.7cm;
    margin-left: 2.3cm;
    margin-top: 0.4cm;
}
