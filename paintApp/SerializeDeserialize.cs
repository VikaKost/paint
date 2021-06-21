using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;


namespace paintApp
{
    public class SerializeDeserialize
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
        private SaveFileDialog save = new SaveFileDialog();
        private OpenFileDialog open = new OpenFileDialog();

        public Image Deserialize()
        {
            Image undo = new Image();
            try
            {
                open.ShowDialog();
                string str = open.FileName;

                using FileStream file = File.OpenRead(str);
                string reader = new StreamReader(file).ReadToEnd();

                undo = JsonConvert.DeserializeObject<Image>(reader, settings);
                for (int i = 0; i < undo.figures.Count; i++)
                {
                    undo.figures[i].figurePen = new Pen(undo.figures[i].PenColor, undo.figures[i].PenWidth);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return undo;
        }

        public void Serialize(Image undo)
        {
            JsonSerializer serialize = JsonSerializer.Create(settings);
            try
            {
                save.DefaultExt = ".json";
                save.Filter = "JSON files (*.json)|*json|Text files (*.txt)|*txt";
                save.ShowDialog();

                string str = save.FileName;
                using StreamWriter SWriter = new StreamWriter(str);
                using JsonWriter JWriter = new JsonTextWriter(SWriter);

                serialize.Serialize(JWriter, undo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
