using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class JoypadSpace
    {
        IEnumerable<IEnumerable<Buttons>> GameActionsSelected { get; set; }
        public JoypadSpace()
        {
            GameActionsSelected = GameActions.RightOnly;
        }

        public JoypadSpace(IEnumerable<IEnumerable<Buttons>> actionsSelected)
        {
            GameActionsSelected = actionsSelected;
        }
        public IEnumerable<Buttons> GetSample()
        {
            int index = Utils.RandRange(0, GameActionsSelected.Count());
            return GameActionsSelected.ElementAt(index);
        }
    }
}
