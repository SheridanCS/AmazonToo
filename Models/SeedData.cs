using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonToo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AmazonDbContext(serviceProvider.GetRequiredService<DbContextOptions<AmazonDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.Add(
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = "Timothy Catibog",
                        Email = "catibogt@sheridancollege.ca",
                        IsPrimeMember = true,
                        Addresses = new List<UserAddress>() {
                            new UserAddress
                            {
                                AddressLine1 = "123 Fake Street",
                                AddressLine2 = "",
                                Province = Province.ON,
                                Country = Country.CA
                            }
                        }
                    }
                );
                context.Products.AddRange(
                    new Product
					{
						Id = 1,
						Title = "AMD Ryzen 5 3600 6-Core, 12-thread unlocked desktop processor with Wraith Stealth cooler.",
						UnitPrice = new decimal(244.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71WPGXQLcLL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 2,
						Title = "Razer Gaming Mouse Bungee v2: Drag-Free Wired Mouse Support - for Esports-Level Performance - Matte Black",
						UnitPrice = new decimal(19.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61JasIJ-mwL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 3,
						Title = "Razer Sphex V2 Gaming Mousepad",
						UnitPrice = new decimal(14.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71wvjUf7tcL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 4,
						Title = "AMD Ryzen 7 3700X 8-core, 16-thread processor with Wraith Prism LED Cooler",
						UnitPrice = new decimal(429.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71TxPH4j0vL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 5,
						Title = "Elgato Game Capture HD60 S - stream, record and share your gameplay in 1080p60, superior low latency technology, USB 3.0, for PS4, Xbox One and Nintendo Switch",
						UnitPrice = new decimal(159.95),
						Image = "https://images-na.ssl-images-amazon.com/images/I/51QXd5YcvcL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 6,
						Title = "AMD Ryzen 7 2700X Processor with Wraith Prism LED Cooler - YD270XBGAFBOX",
						UnitPrice = new decimal(209.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61wP16xC7tL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 7,
						Title = "Razer Kraken Gaming Headset 2019: Lightweight Aluminum Frame - Retractable Noise Cancelling Mic - For PC, Xbox, PS4, Nintendo Switch - Black",
						UnitPrice = new decimal(69.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61W9lG1pCXL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 8,
						Title = "Razer Firefly Chroma Cloth Gaming Mousepad: Customizable Chroma RGB Lighting - 14\"x10\" - Balanced Control & Speed - Non-Slip Rubber Base",
						UnitPrice = new decimal(49.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71J-IcWKGiL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 9,
						Title = "Elgato Stream Deck - Live Content Creation Controller with 15 customizable LCD keys, adjustable stand, for Windows 10 and macOS 10.11 or later",
						UnitPrice = new decimal(139.95),
						Image = "https://images-na.ssl-images-amazon.com/images/I/710R9YpV9nL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 10,
						Title = "Razer Kraken Gaming Headset 2019: Lightweight Aluminum Frame - Retractable Cardioid Mic - For PC, Xbox, PS4, Nintendo Switch - Green",
						UnitPrice = new decimal(69.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61AMW91VjqL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 11,
						Title = "Razer Huntsman: Opto-Mechanical Switch - Hybrid On-Board Memory & Cloud Storage - Durability of up to 100 Million Keystrokes - Light and Clicky Gaming Keyboard",
						UnitPrice = new decimal(139.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71FJGmeJ2GL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 12,
						Title = "Elgato Cam Link 4K — Broadcast Live, Record via DSLR, Camcorder, or Action cam, 1080p60 or 4K at 30 fps, Compact HDMI Capture Device, USB 3.0",
						UnitPrice = new decimal(139.95),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61pWBRbG98L._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 13,
						Title = "Razer Goliathus Chroma Gaming Mousepad: Customizable Chroma RGB Lighting - Soft, Cloth Material - Balanced Control & Speed - Non-Slip Rubber Base - Matte Black",
						UnitPrice = new decimal(39.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/91G-JYStqwL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 14,
						Title = "Razer Kraken Tournament Edition THX 7.1 Surround Sound Gaming Headset: Aluminum Frame - Retractable Noise Cancelling Mic - USB DAC Included - For PC, Xbox, PS4, Nintendo Switch - Green",
						UnitPrice = new decimal(79.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61Ufzi3lugL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 15,
						Title = "AMD Ryzen 7 3800X 8-core, 16-thread unlocked desktop processor with Wraith Prism LED Cooler",
						UnitPrice = new decimal(444.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71S4mkgvGNL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 16,
						Title = "Razer Mamba Elite Wired Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 9 Programmable Buttons - Mechanical Switches",
						UnitPrice = new decimal(69.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61pz6N01NJL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 17,
						Title = "Razer Nari Wireless 7.1 Surround Sound Gaming Headset: THX Audio - Auto-Adjust Headband & Swivel Cups - Chroma RGB - Retractable Mic - for PC, PS4, Xbox One - Black",
						UnitPrice = new decimal(129.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/51CguHFmDqL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 18,
						Title = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Green Mechanical Switches - Tactile & Clicky - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
						UnitPrice = new decimal(149.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 19,
						Title = "MSI Optix AG32C Full HD Non-Flare Curve 32\" VA Panel 1ms 1920 x 1080 165HzFreeSync Gaming Monitor w/Height Adjustment, Super Narrow Bezel",
						UnitPrice = new decimal(349.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/61g6iwQPHXL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 20,
						Title = "MSI Full HD Non-Glare Super Narrow Bezel 1ms 1920 X 1080 144Hz Refresh RateTrue Color FreeSync 27” Curved Gaming Monitor (OPTIX G27C2)",
						UnitPrice = new decimal(249.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81R49k0FMYL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 21,
						Title = "Razer Basilisk Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 8 Programmable Buttons - Mechanical Switches - Customizable Scroll Resistance - Matte Black",
						UnitPrice = new decimal(59.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71oYOFlv9rL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 22,
						Title = "Razer BlackWidow Mechanical Gaming Keyboard 2019: Green Mechanical Switches- Tactile & Clicky - Chroma RGB Lighting - Anti-Ghosting - Programmable Macro Functionality",
						UnitPrice = new decimal(109.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71sXzUqI9XL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 23,
						Title = "Razer DeathAdder Essential Gaming Mouse: 6400 DPI Optical Sensor - Chroma RGB Lighting - 5 Programmable Buttons - Mechanical Switches - Rubber Side Grips - White",
						UnitPrice = new decimal(39.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/51O9tbUuOHL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 24,
						Title = "Elgato Stream Deck XL - Live Content Creation Controller with 32 Customizable LCD Keys, Adjustable Stand, for Windows 10 and macOS 10.11 or Later",
						UnitPrice = new decimal(269.95),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71aY+mfIxiL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 25,
						Title = "MSI Force GC30 Wireless Rechargeable Dual Vibration Gaming Controller for PC, Android and Sony Playstation 4",
						UnitPrice = new decimal(39.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/51ZAA4YElTL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 26,
						Title = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Yellow Mechanical Switches - Linear & Silent - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
						UnitPrice = new decimal(139.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 27,
						Title = "Razer BlackWidow Elite Mechanical Gaming Keyboard: Orange Mechanical Switches - Tactile & Silent - Chroma RGB Lighting - Magnetic Wrist Rest - Dedicated Media Keys & Dial - USB Passthrough",
						UnitPrice = new decimal(139.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81oLMQUj4fL._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 28,
						Title = "AOPEN 24MX1 bii 24-inch Full HD (1920 x 1080) Gaming Monitor with AMD Radeon FreeSync Technology (2 x HDMI & VGA Port), Black",
						UnitPrice = new decimal(126.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/71Br2w7Uo1L._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 29,
						Title = "Razer BlackWidow TE Chroma v2 Mechanical Gaming Keyboard: Green Key Switches - Tactile & Clicky - Chroma RGB Lighting - Magnetic Wrist Rest - Programmable Macro Functionality - Matte Black",
						UnitPrice = new decimal(139.99),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81lxQgJ8B6L._AC_SR300,300_.jpg",
						IsPrime = true
					},
					new Product
					{
						Id = 30,
						Title = "Asus ROG Strix Hero II Gaming Laptop, 15.6” 144Hz IPS-Type Display, GTX1060 6GB, Core i7-8750H, 256GB SSD Plus 1TB HDD, 16GB DDR4 GL504GM-XS74",
						UnitPrice = new decimal(1079.00),
						Image = "https://images-na.ssl-images-amazon.com/images/I/81RIr5YR3QL._AC_SR300,300_.jpg",
						IsPrime = true
					}
                );
                context.SaveChanges();
            }
        }
    }
}