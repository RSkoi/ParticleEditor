using System;
using UnityEngine;

namespace RSkoi_ParticleEditor {
    partial class ParticleEditor {
        private static void SetShapeProperty(ParticleSystem.ShapeModule shape, ShapeProperty shp) {
            shape.enabled = shp.Enabled;
            shape.shapeType = (ParticleSystemShapeType)shp.Mode;
            shape.radius = shp.Radius;
            shape.alignToDirection = shp.AlignDirection;
            shape.randomDirectionAmount = shp.RandomDirAmount;
            shape.sphericalDirectionAmount = shp.SphereDirAmount;
            shape.arc = shp.Arc;
            shape.angle = shp.ArcAngle;
            shape.arcMode = (ParticleSystemShapeMultiModeValue)shp.ArcMode;
            shape.arcSpread = shp.ArcSpread;
            var arcS = shape.arcSpeed;
            arcS.constant = shp.ArcSpeed;
            shape.arcSpeed = arcS;
            shape.radiusMode = (ParticleSystemShapeMultiModeValue)shp.RadiusMode;
            shape.radiusSpread = shp.RadiusSpread;
            var radS = shape.radiusSpeed;
            radS.constant = shp.RadiusSpeed;
            shape.radiusSpeed = radS;
            var box = shape.box;
            box.x = shp.BoxX;
            box.y = shp.BoxY;
            box.z = shp.BoxZ;
            shape.box = box;
        }
    }
}
