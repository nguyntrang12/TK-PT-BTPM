using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Flyweight (Trọng lượng nhẹ)
/// </summary>
public class Program
    {
        public static void Main(string[] args)
        {
        // Xây dựng một tài liệu với văn bản
        string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();
            CharacterFactory factory = new CharacterFactory();
        // Trạng thái bên ngoài (extrinsic state)
        int pointSize = 10;
        // Dành cho mỗi ký tự sử dụng một đối tượng flyweight
        foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        // Chờ người dùng nhấn phím
        Console.ReadKey();
        }
    }
