> This project is built in C#, which can be unstable, as (primarily) the implementation of the protocol is entirely designed by me. The main branch isn't probably stable for production use, in the future however, there will most likely be production releases.

# Atlas Network (C#)

A (incredibly complex and low dependency usage) recreation of Hypixel Skyblock. Each section of code will be mentioned below, as each are split into unique sections.

## Code Sections (Explanation)

Each part of the server is split into many different sections, this is meant to decrease the number of code running, as well as to reduce memory usage. Each game server will have the core Skyblock Implementation, and then include any other local package dependencies it needs. 

## Atlas.Logger
> Basic debug logger implementation, nothing too special. Meant for use to fix bugs.

## Atlas.Minecraft
> Implementation of Minecraft Systems, such as Items, Blocks, etc. This is different than Atlas.DataTypes, which is more systems based.

## Atlas.Protocol
> Our custom C# Minecraft Protocol implementation! This is a very dynamic, multi proxy registerable, fast, and efficient protocol system! To use, extend IProtocol, and IProtocolWriter, register the writer inside of IProtocol implementation, and then register it and you're done!

## Atlas.DataTypes
> Just some basic Data Type implementations, meant for closer to systems based data types.

## Atlas.Proxy
> The Atlas Server Proxy, meant to handle connection between servers, and then handle it back to the client.

## Atlas
> Atlas Core! This is the main Atlas loader, implementation, etc. Not much going on here (yet!)

# Okay, so how do I help?

You can help by forking the repository, adding features, fixing code, etc, and then merge! Any help is well appreciated, as solo far (as of 3/26/2024) this has been a solo project. And you don't need to add big commits! You can simply add a line of code (as long as its useful) or fix a spelling mistake. Any code is helpful!

# I want to help, how do I setup?

To setup, fork the repository, download it, download .NET Framework 7.0, and then open the directory of the code you want to edit. Simple as that! To test your code, you can use: `dotnet run` inside of the Atlas directory.

# Credits

me rn only lol



