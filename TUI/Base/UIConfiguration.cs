﻿using System;

namespace TUI.Base
{
    public class UIConfiguration
    {
        /// <summary>
        /// Visual grid configuration.
        /// </summary>
        public GridConfiguration Grid { get; set; }
        /// <summary>
        /// Touching this node would prevent touches on it or on the whole root for some time.
        /// </summary>
        public LockConfig Lock { get; set; }
        /// <summary>
        /// Object that should be used for checking if user can touch this node (permission string for TShock).
        /// </summary>
        public object Permission { get; set; }
        /// <summary>
        /// Delegate for applying custom actions on Update().
        /// </summary>
        public Action<VisualObject> CustomUpdate { get; set; }
        /// <summary>
        /// Delegate for custom checking if user can touch this node.
        /// </summary>
        public Func<VisualObject, Touch, bool> CustomCanTouch { get; set; }
        /// <summary>
        /// Delegate for applying custom actions on Apply().
        /// </summary>
        public Action<VisualObject> CustomApply { get; set; }

        /// <summary>
        /// Once node is touched all future touches within the same session would pass to this node.
        /// </summary>
        public bool SessionAcquire { get; set; } = true;
        /// <summary>
        /// Allows to touch this node only if current session began with touching it.
        /// </summary>
        public bool BeginRequire { get; set; } = true;
        /// <summary>
        /// Only for nodes with SessionAcquire. Passes touches even if they are not inside.
        /// </summary>
        public bool UseOutsideTouches { get; set; } = false;
        /// <summary>
        /// Touching this node would move it on top of Child array so that it would draw
        /// at highest layer and check for touching first.
        /// </summary>
        public bool Ordered { get; set; } = false;
        /// <summary>
        /// Allows to touch this node only if touch.State == TouchState.Begin
        /// </summary>
        public bool UseBegin { get; set; } = true;
        /// <summary>
        /// Allows to touch this node only if touch.State == TouchState.Moving
        /// </summary>
        public bool UseMoving { get; set; } = false;
        /// <summary>
        /// Allows to touch this node only if touch.State == TouchState.End
        /// </summary>
        public bool UseEnd { get; set; } = false;
        /// <summary>
        /// Node size completely matches parent size/parent cell size.
        /// </summary>
        public bool FullSize { get; set; } = false;
        //public bool Orderable { get; set; } = true;

        public UIConfiguration() { }

        public UIConfiguration(UIConfiguration configuration)
        {
            this.Grid = new GridConfiguration(configuration.Grid);
            this.Lock = new LockConfig(configuration.Lock);
            this.Permission = configuration.Permission;
            this.CustomUpdate = configuration.CustomUpdate?.Clone() as Action<VisualObject>;
            this.CustomCanTouch = configuration.CustomCanTouch?.Clone() as Func<VisualObject, Touch, bool>;
            this.CustomApply = configuration.CustomApply?.Clone() as Action<VisualObject>;
            this.SessionAcquire = configuration.SessionAcquire;
            this.BeginRequire = configuration.BeginRequire;
            this.UseOutsideTouches = configuration.UseOutsideTouches;
            this.Ordered = configuration.Ordered;
            this.UseBegin = configuration.UseBegin;
            this.UseMoving = configuration.UseMoving;
            this.UseEnd = configuration.UseEnd;
            this.FullSize = configuration.FullSize;
        }
    }
}
