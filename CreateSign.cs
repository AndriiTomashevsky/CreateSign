string data = "{\"order\":{\"serviceKey\":\"MERCHANT-TEST\",\"orderId\":\"18050\",\"description\":\"string\",\"amount\":0,25\"}}";
byte[] secretKeyByteArray = Encoding.UTF8.GetBytes(SecretKey);
byte[] dataByteArray = Encoding.UTF8.GetBytes(data);
var sign = Signature.CreateSign(secretKeyByteArray, dataByteArray);
	
public static string CreateSign(byte[] key, byte[] data)
{
	using (var hmacsha256 = new HMACSHA256(key))
	{
		byte[] hashData = hmacsha256.ComputeHash(data);
		return Convert.ToBase64String(hashData);
	}
}
