using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AmazonToo.Models;

namespace AmazonToo.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    },
                    new Product
                    {
                        Name = "Basketball",
                        Description = "NBA-approved size and weight",
                        Category = "Basketball",
                        Price = 49.50m
                    },
                    new Product
                    {
                        
                        Name = "AMD Ryzen 5 3600 6-Core, 12-thread unlocked desktop processor with Wraith Stealth cooler.",
                        Description = "Lorem Ipsum",
                        Price = 244.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71WPGXQLcLL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    },
                    new Product
                    {
                        
                        Name = "Razer Gaming Mouse Bungee v2: Drag-Free Wired Mouse Support - for Esports-Level Performance - Matte Black",
                        Description = "Lorem Ipsum",
                        Price = 19.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61JasIJ-mwL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    },
                    new Product
                    {
                        
                        Name = "Razer Sphex V2 Gaming Mousepad",
                        Description = "Lorem Ipsum",
                        Price = 14.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71wvjUf7tcL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    },
                    new Product
                    {
                        
                        Name = "AMD Ryzen 7 3700X 8-core, 16-thread processor with Wraith Prism LED Cooler",
                        Description = "Lorem Ipsum",
                        Price = 429.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71TxPH4j0vL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Elgato Game Capture HD60 S - stream, record and share your gameplay in 1080p60, superior low latency technology, USB 3.0, for PS4, Xbox One and Nintendo Switch",
                        Description = "Lorem Ipsum",
                        Price = 159.95m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/51QXd5YcvcL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "AMD Ryzen 7 2700X Processor with Wraith Prism LED Cooler - YD270XBGAFBOX",
                        Description = "Lorem Ipsum",
                        Price = 209.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61wP16xC7tL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Kraken Gaming Headset 2019: Lightweight Aluminum Frame - Retractable Noise Cancelling Mic - For PC, Xbox, PS4, Nintendo Switch - Black",
                        Description = "Lorem Ipsum",
                        Price = 69.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61W9lG1pCXL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Firefly Chroma Cloth Gaming Mousepad: Customizable Chroma RGB Lighting - 14\"x10\" - Balanced Control & Speed - Non-Slip Rubber Base",
                        Description = "Lorem Ipsum",
                        Price = 49.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71J-IcWKGiL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Elgato Stream Deck - Live Content Creation Controller with 15 customizable LCD keys, adjustable stand, for Windows 10 and macOS 10.11 or later",
                        Description = "Lorem Ipsum",
                        Price = 139.95m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/710R9YpV9nL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Kraken Gaming Headset 2019: Lightweight Aluminum Frame - Retractable Cardioid Mic - For PC, Xbox, PS4, Nintendo Switch - Green",
                        Description = "Lorem Ipsum",
                        Price = 69.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61AMW91VjqL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Huntsman: Opto-Mechanical Switch - Hybrid On-Board Memory & Cloud Storage - Durability of up to 100 Million Keystrokes - Light and Clicky Gaming Keyboard",
                        Description = "Lorem Ipsum",
                        Price = 139.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71FJGmeJ2GL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Elgato Cam Link 4K — Broadcast Live, Record via DSLR, Camcorder, or Action cam, 1080p60 or 4K at 30 fps, Compact HDMI Capture Device, USB 3.0",
                        Description = "Lorem Ipsum",
                        Price = 139.95m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61pWBRbG98L._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Goliathus Chroma Gaming Mousepad: Customizable Chroma RGB Lighting - Soft, Cloth Material - Balanced Control & Speed - Non-Slip Rubber Base - Matte Black",
                        Description = "Lorem Ipsum",
                        Price = 39.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/91G-JYStqwL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Kraken Tournament Edition THX 7.1 Surround Sound Gaming Headset: Aluminum Frame - Retractable Noise Cancelling Mic - USB DAC Included - For PC, Xbox, PS4, Nintendo Switch - Green",
                        Description = "Lorem Ipsum",
                        Price = 79.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61Ufzi3lugL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "AMD Ryzen 7 3800X 8-core, 16-thread unlocked desktop processor with Wraith Prism LED Cooler",
                        Description = "Lorem Ipsum",
                        Price = 444.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71S4mkgvGNL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Mamba Elite Wired Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 9 Programmable Buttons - Mechanical Switches",
                        Description = "Lorem Ipsum",
                        Price = 69.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61pz6N01NJL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Nari Wireless 7.1 Surround Sound Gaming Headset: THX Audio - Auto-Adjust Headband & Swivel Cups - Chroma RGB - Retractable Mic - for PC, PS4, Xbox One - Black",
                        Description = "Lorem Ipsum",
                        Price = 129.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/51CguHFmDqL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Green Mechanical Switches - Tactile & Clicky - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
                        Description = "Lorem Ipsum",
                        Price = 149.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "MSI Optix AG32C Full HD Non-Flare Curve 32\" VA Panel 1ms 1920 x 1080 165HzFreeSync Gaming Monitor w/Height Adjustment, Super Narrow Bezel",
                        Description = "Lorem Ipsum",
                        Price = 349.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/61g6iwQPHXL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "MSI Full HD Non-Glare Super Narrow Bezel 1ms 1920 X 1080 144Hz Refresh RateTrue Color FreeSync 27” Curved Gaming Monitor (OPTIX G27C2)",
                        Description = "Lorem Ipsum",
                        Price = 249.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81R49k0FMYL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer Basilisk Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 8 Programmable Buttons - Mechanical Switches - Customizable Scroll Resistance - Matte Black",
                        Description = "Lorem Ipsum",
                        Price = 59.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71oYOFlv9rL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer BlackWidow Mechanical Gaming Keyboard 2019: Green Mechanical Switches- Tactile & Clicky - Chroma RGB Lighting - Anti-Ghosting - Programmable Macro Functionality",
                        Description = "Lorem Ipsum",
                        Price = 109.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71sXzUqI9XL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer DeathAdder Essential Gaming Mouse: 6400 DPI Optical Sensor - Chroma RGB Lighting - 5 Programmable Buttons - Mechanical Switches - Rubber Side Grips - White",
                        Description = "Lorem Ipsum",
                        Price = 39.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/51O9tbUuOHL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Elgato Stream Deck XL - Live Content Creation Controller with 32 Customizable LCD Keys, Adjustable Stand, for Windows 10 and macOS 10.11 or Later",
                        Description = "Lorem Ipsum",
                        Price = 269.95m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71aY+mfIxiL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    },
                    new Product
                    {
                        
                        Name = "MSI Force GC30 Wireless Rechargeable Dual Vibration Gaming Controller for PC, Android and Sony Playstation 4",
                        Description = "Lorem Ipsum",
                        Price = 39.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/51ZAA4YElTL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Yellow Mechanical Switches - Linear & Silent - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
                        Description = "Lorem Ipsum",
                        Price = 139.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Orange Mechanical Switches - Tactile & Silent - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
                        Description = "Lorem Ipsum",
                        Price = 139.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    },
                    new Product
                    {
                        
                        Name = "AOPEN 24MX1 bii 24-inch Full HD (1920 x 1080) Gaming Monitor with AMD Radeon FreeSync Technology (2 x HDMI & VGA Port), Black",
                        Description = "Lorem Ipsum",
                        Price = 126.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/71Br2w7Uo1L._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Razer BlackWidow TE Chroma v2 Mechanical Gaming Keyboard: Green Key Switches - Tactile & Clicky - Chroma RGB Lighting - Magnetic Wrist Rest - Programmable Macro Functionality - Matte Black",
                        Description = "Lorem Ipsum",
                        Price = 139.99m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81lxQgJ8B6L._AC_SR300,300_.jpg",
                        Category = "Computers"

                    },
                    new Product
                    {
                        
                        Name = "Asus ROG Strix Hero II Gaming Laptop, 15.6” 144Hz IPS-Type Display, GTX1060 6GB, Core i7-8750H, 256GB SSD Plus 1TB HDD, 16GB DDR4 GL504GM-XS74",
                        Description = "Lorem Ipsum",
                        Price = 1079.00m,
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81RIr5YR3QL._AC_SR300,300_.jpg",
                        Category = "Computers"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
