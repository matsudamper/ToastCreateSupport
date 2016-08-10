using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ToastCreateSupport
{
    public class CreateToast
    {
        /// <summary>
        /// <param name="text01">文字</param>
        /// </summary>
        public static ToastNotification Text01(string text01)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字</param>
        /// <param name="text02">文字</param>
        /// </summary>
        public static ToastNotification Text02(string text01, string text02)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[1].AppendChild(doc.CreateTextNode(text02));

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字2行</param>
        /// <param name="text02">文字</param>
        /// </summary>
        public static ToastNotification Text03(string text01, string text02)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText03);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[1].AppendChild(doc.CreateTextNode(text02));

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字1行</param>
        /// <param name="text02">文字</param>
        /// <param name="text03">文字</param>
        /// </summary>
        public static ToastNotification Text04(string text01, string text02, string text03)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText04);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[0].AppendChild(doc.CreateTextNode(text02));
            t_elements[0].AppendChild(doc.CreateTextNode(text03));

            return new ToastNotification(doc);
        }


        /// <summary>
        /// <param name="text01">文字</param>
        /// </summary>
        public static ToastNotification ImageAndText01(string text01, string path)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText01);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));

            XmlNodeList i_elements = doc.GetElementsByTagName("image");
            i_elements[0].Attributes[1].NodeValue = path;

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字</param>
        /// <param name="text02">文字</param>
        /// <param name="path">画像パス</param>
        /// </summary>
        public static ToastNotification ImageAndText02(string text01, string text02, string path)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[1].AppendChild(doc.CreateTextNode(text02));

            XmlNodeList i_elements = doc.GetElementsByTagName("image");
            i_elements[0].Attributes[1].NodeValue = path;

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字2行</param>
        /// <param name="text02">文字</param>
        /// </summary>
        public static ToastNotification ImageAndText03(string text01, string text02, string path)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText03);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[1].AppendChild(doc.CreateTextNode(text02));

            XmlNodeList i_elements = doc.GetElementsByTagName("image");
            i_elements[0].Attributes[1].NodeValue = path;

            return new ToastNotification(doc);
        }

        /// <summary>
        /// <param name="text01">太文字1行</param>
        /// <param name="text02">文字</param>
        /// <param name="text03">文字</param>
        /// </summary>
        public static ToastNotification ImageAndText04(string text01, string text02, string text03, string path)
        {
            XmlDocument doc = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            XmlNodeList t_elements = doc.GetElementsByTagName("text");
            t_elements[0].AppendChild(doc.CreateTextNode(text01));
            t_elements[0].AppendChild(doc.CreateTextNode(text02));
            t_elements[0].AppendChild(doc.CreateTextNode(text03));

            XmlNodeList i_elements = doc.GetElementsByTagName("image");
            i_elements[0].Attributes[1].NodeValue = path;

            return new ToastNotification(doc);
        }
    }
}
