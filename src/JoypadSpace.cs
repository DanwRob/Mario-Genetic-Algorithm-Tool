using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class JoypadSpace
    {
        private readonly int stepByFrame = 5;

        IEnumerable<IEnumerable<Buttons>> GameActionsSelected { get; set; }
        public JoypadSpace()
        {
            GameActionsSelected = GameActions.RightOnly;
        }

        public JoypadSpace(IEnumerable<IEnumerable<Buttons>> actionsSelected)
        {
            GameActionsSelected = actionsSelected;
        }

        public FrameAction GetFrameActionSample()
        {
            int index = Utils.RandRange(0, GameActionsSelected.Count());
            var action = GameActionsSelected.ElementAt(index);

            int framesByAction = Utils.RandRange(1, 5, stepByFrame);
            return new FrameAction(framesByAction, action);
        }
    }
}
