﻿using JMXFileEditor.Silkroad.Data.JMXVEFF.Parameter;
using JMXFileEditor.Silkroad.Mathematics;
using JMXFileEditor.ViewModels.Silkroad.Mathematics;

namespace JMXFileEditor.ViewModels.Silkroad.JMXVEFF.Parameter
{
    public class ParameterFrameBANPositionVM : JMXStructure
    {
        #region Constructor
        public ParameterFrameBANPositionVM(string Name, ParameterFrameBANPosition data) : base(Name, true)
        {
            Childs.Add(new JMXAttribute("Left", data.Left));
            AddFormatHandler(typeof(Vector3), (s, e) =>
            {
                e.Childs.Add(new Vector3VM("[" + e.Childs.Count + "]", e.Obj is Vector3 _obj ? _obj : new Vector3()));
            });
            AddChildArray("Right", data.Right.ToArray(), true, true);
        }
        #endregion

        #region Public Methods
        public override object GetClassFrom(JMXStructure s, int i)
        {
            return new ParameterFrameBANPosition(
                (float)((JMXAttribute)s.Childs[i++]).Value,
                ((JMXStructure)s.Childs[i++]).GetChildList<Vector3>()
                );
        }
        #endregion
    }
}
