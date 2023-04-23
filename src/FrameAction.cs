using System.Collections.Generic;

namespace GeneticAlgorithmTool
{
    public class FrameAction
    {
        private int frameCount;
        public FrameAction(int totalFrames, IEnumerable<Buttons> actions)
        {
            TotalFrames = totalFrames;
            Actions = actions;
            frameCount = 1;
        }

        public FrameAction Clone() 
        {
            var newActions = new List<Buttons>();
            foreach (Buttons b in Actions)
            {
                newActions.Add(b);
            }
            return new FrameAction(TotalFrames, newActions);
        }

        public void AdvanceFrame() => frameCount++;

        public bool IsFinishAction() => frameCount >= TotalFrames;

        public int TotalFrames { get; }
        public IEnumerable<Buttons> Actions { get; }
        public int Score { get; set; } = 0;
        public int XPosition { get; set; }
        public int YPosition { get; set; } = -1;
        public int Time { get; set; } = 400;
        public int Coins { get; set; } = 0;
    }
}
