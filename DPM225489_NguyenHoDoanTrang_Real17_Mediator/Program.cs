using System;
using System.Collections.Generic;

    /// <summary>
    /// Mẫu thiết kế Mediator
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo phòng chat

            Chatroom chatroom = new Chatroom();

            // Tạo các người tham gia và đăng ký họ

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Các người tham gia trò chuyện

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Chờ người dùng

            Console.ReadKey();
        }
    }

