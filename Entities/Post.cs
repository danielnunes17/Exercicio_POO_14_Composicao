using System.Text;

namespace Exercicio_POO_14_Composicao.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }

        public List<Comment> Coments = new List<Comment>();

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }

        public void AddComments(Comment comment) => Coments.Add(comment);
        public void RemoveComents(Comment comment) => Coments.Remove(comment);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like);
            sb.AppendLine(" - Likes");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Coments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
