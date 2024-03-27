//Current goal: save memory (and brain power) by bit shifting the id of every item (plus metadata types) into a single short.

uint testUnpack = 0;

Console.WriteLine("PackId test to convert is " + (testUnpack = PackId(397, 4)));

Console.WriteLine("UnpackId test");

uint[] test = UnpackId(testUnpack);

Console.WriteLine("Id is " + test[0] + " and metadata is " + test[1]);

//Functions to unpack and pack
uint PackId(uint id, uint metadata = 0)
{
    //(00 00 00 00 00 00 00 00)
    // This is the first half of the int.
    // This half is going to be dedicated to the metadata.
    //(00 00 00 00 00 00 00 00)
    // This is the second half. This is the actual id.
    // The hard part of packing this into an integer is storing the values at the same time.
    // 
    //00 00 00 00 00 00 00 00 | 00 00 00 00 00 00 00 00
    // I would pack id as a ushort, but minecraft has some items (for no reason) that's metadata value goes up to 16500.
    // stupid minecraft, why???

    return (metadata << 16) + id;
}

uint[] UnpackId(uint full)
{
    //This is the hard part. Unpacking the int.
    //(00 00 00 00 00 00 00 00) (00 00 00 00 00 00 00 00)
    // We have two shorts in this packed int.
    // To unpack, we must first find the plain metadata.

    uint metadata = (full >> 16);

    //This should drop the id.
    //Then, we must find the value of only the metadata.

    uint maxMeta = metadata << 16;
    uint id = full - maxMeta;

    return new uint[]{id, metadata};
}