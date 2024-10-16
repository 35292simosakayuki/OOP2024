using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    public interface ITextFileService {
        void Initialize(string fname);
        void Execute(string line);
        void Terminate();
    }
    public class TextFileProcessor {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }
            public void Run(string fname) {
                _service.Initialize(fname);
                using (var sr = new StreamReader(fname)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        _service.Execute(line);
                    }
                }
                _service.Terminate();
            }
        }

    }



