﻿using Kooboo.Sites.Render;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Render.Components
{
    public class Component
    {
        private string _fulldiskpath; 
        public string FullDiskPath {
            get
            {
                return _fulldiskpath; 
            }
            set
            {
                _fulldiskpath = value;
                _rendertask = null; 
            }
        }

        public Guid SourceHash { get; set; }

        public DateTime LastModified { get; set; }

        private List<IRenderTask> _rendertask; 

        public List<IRenderTask> RenderTasks
        {
            get
            {
                if (_rendertask== null)
                {
                    if (System.IO.File.Exists(this.FullDiskPath))
                    {
                        var html = System.IO.File.ReadAllText(this.FullDiskPath);
                        var option = new EvaluatorOption();
                        option.Evaluators = Kooboo.Render.Components.EvaluatorContainer.ListWithServerComponent; 
                        _rendertask = Kooboo.Sites.Render.RenderEvaluator.Evaluate(html, option); 
                    } 
                }
                return _rendertask; 

            }
            set
            {
                _rendertask = value; 
            }

        }

         
    }
}
