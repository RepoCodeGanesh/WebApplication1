var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => 
{
    context.Response.ContentType = "text/html";
    return @"
    <html>
    <head>
        <title>Article about Elephants</title>
        <style>
            .left-image, .right-image {
                width: 25%;
                height: auto;
            }
            .left-image {
                float: left;
                margin-right: 20px;
            }
            .right-image {
                float: right;
                margin-left: 20px;
            }
        </style>
    </head>
    <body>
        <h1>Elephants</h1>
        <img class='left-image' src='https://files.worldwildlife.org/wwfcmsprod/images/African_elephant_YE2021_Karine_Aigner_5kzx389mvt/magazine_small/1s803ne5x2_elephantv2.jpg' />
        <img class='right-image' src='https://files.worldwildlife.org/wwfcmsprod/images/African_elephant_YE2021_Karine_Aigner_5kzx389mvt/magazine_small/1s803ne5x2_elephantv2.jpg' />
        <p>Elephants are the largest land animals on Earth. They are known for their intelligence, social behavior, and strong familial bonds. Elephants are native to Africa and Asia, and they play a crucial role in their ecosystems.</p>
        <h2>Types of Elephants</h2>
        <p>There are three main species of elephants:</p>
        <ul>
            <li>African Bush Elephant</li>
            <li>African Forest Elephant</li>
            <li>Asian Elephant</li>
        </ul>
        <h2>Physical Characteristics</h2>
        <p>Elephants are known for their large ears, tusks made of ivory, and long trunks. Their trunks are versatile and can be used for breathing, lifting water, and grasping objects.</p>
        <h2>Behavior and Social Structure</h2>
        <p>Elephants are highly social animals and live in herds led by a matriarch. They communicate through vocalizations, body language, and even seismic signals.</p>
        <h2>Conservation Status</h2>
        <p>Many elephant populations are threatened by habitat loss and poaching. Conservation efforts are crucial to protect these magnificent creatures for future generations.</p>
    </body>
    </html>";
});

app.Run();
