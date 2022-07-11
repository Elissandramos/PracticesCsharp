using System.Text;


namespace PracticesCsharp03Enum.Entities03
{
     class Post
    {
        // # Properties
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // associate compositions (check the arrow assocition in the diagram)
        // remmeber instanciate and initiate lists -> public List <type> Name = new List <type>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

        // # properties
        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        { 
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;              
        }

        public void AddComment(Comment comment) 
        { 
            Comments.Add(comment);  
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        // using "toString" method to change the objetct in string.
        // using also the object "String builder" of the "System.Text"
        // to define better how it will be printed of the objetc, now ,as a string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments : ");

            foreach (Comment c in Comments) 
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }

    }
}
