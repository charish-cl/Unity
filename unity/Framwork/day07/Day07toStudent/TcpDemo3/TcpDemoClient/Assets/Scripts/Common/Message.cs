using UnityEngine;
using System.IO;
using System.Text;
//[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
/// <summary>
/// 消息以及消息格式的转换
/// </summary>
public struct Message
{
    public string CharacterName { get; set; }
    public Vector3 Position { get; set; }
    public Quaternion Rotation { get; set; }
    //结构体转字节数组
    public byte[] StructToBytes()
    {
        using (MemoryStream ms = new MemoryStream())
        {
            BinaryWriter bw = new BinaryWriter(ms); 
            if (CharacterName == null) CharacterName = string.Empty;

            byte[] byteCharacterName = Encoding.Unicode.GetBytes(CharacterName); 
            bw.Write(byteCharacterName.Length);
            bw.Write(byteCharacterName); 
            bw.Write(this.Position.x);
            bw.Write(this.Position.y);
            bw.Write(this.Position.z);

            bw.Write(this.Rotation.x);
            bw.Write(this.Rotation.y);
            bw.Write(this.Rotation.z);
            bw.Write(this.Rotation.w);

            return ms.ToArray();
        } 
        //int size = Marshal.SizeOf(typeof(Message));
        //System.IntPtr buffer = Marshal.AllocHGlobal(size);
        //try
        //{
        //    Marshal.StructureToPtr(this, buffer, false);
        //    byte[] bytes = new byte[size];
        //    Marshal.Copy(buffer, bytes, 0, size);
        //    return bytes;
        //}
        //finally
        //{
        //    Marshal.FreeHGlobal(buffer);
        //}
    }
    //字节数组转结构体
    public static Message BytesToStruct(byte[] bytes)
    {
        using (MemoryStream ms = new MemoryStream(bytes))
        {
            BinaryReader br = new BinaryReader(ms);
            int count = br.ReadInt32();
            byte[] byteCharacterName = br.ReadBytes(count);
            string characterName = Encoding.Unicode.GetString(byteCharacterName);
            Vector3 position = new Vector3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
            Quaternion rotation = new Quaternion(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle());

            return new Message() { CharacterName = characterName, Position = position, Rotation = rotation };
        } 
        //int size = Marshal.SizeOf(typeof(Message));
        //System.IntPtr buffer = Marshal.AllocHGlobal(size);
        //try
        //{
        //    Marshal.Copy(bytes, 0, buffer, size);
        //    return (Message)Marshal.PtrToStructure(buffer, typeof(Message));
        //}
        //finally
        //{
        //    Marshal.FreeHGlobal(buffer);
        //} 
    } 
}
