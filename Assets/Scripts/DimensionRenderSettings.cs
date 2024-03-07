using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable]
public class DimensionRenderSettings
{
    // fuck you unity :middle-finger:
    [System.Serializable]
    public class DimensionRenderSettingsObject
    {
        public DimensionRGBColor ambientEquatorColor;
        public DimensionRGBColor ambientGroundColor;
        public float ambientIntensity;
        public DimensionRGBColor ambientLight;
        public AmbientMode ambientMode;
        public SphericalHarmonicsL2 ambientProbe;
        public float ambientSkyboxAmount;
        public DimensionRGBColor ambientSkyColor;
        public Cubemap customReflection;
        public Texture customReflectionTexture;
        public DefaultReflectionMode defaultReflectionMode;
        public int defaultReflectionResolution;
        public float flareFadeSpeed;
        public float flareStrength;
        public bool fog;
        public DimensionRGBColor fogColor;
        public float fogDensity;
        public float fogEndDistance;
        public FogMode fogMode;
        public float fogStartDistance;
        public float haloStrength;
        public int reflectionBounces;
        public float reflectionIntensity;
        //public Material skybox;
        public string skyboxName;
        public DimensionRGBColor subtractiveShadowColor;
        //public Light sun;
        public string sunName;
    }

    [System.Serializable]
    public class DimensionRGBColor
    {
        public float r;
        public float g;
        public float b;
        public float a;
    }

    public static DimensionRGBColor CopyColor(Color color)
    {
        DimensionRGBColor dimensionColor = new DimensionRGBColor();
        dimensionColor.r = color.r;
        dimensionColor.g = color.g;
        dimensionColor.b = color.b;
        dimensionColor.a = color.a;
        return dimensionColor;
    }

    public static DimensionRenderSettingsObject CopySettings()
    {
        DimensionRenderSettingsObject dimensionSettings = new DimensionRenderSettingsObject();
        dimensionSettings.ambientEquatorColor = CopyColor(RenderSettings.ambientEquatorColor);
        dimensionSettings.ambientGroundColor = CopyColor(RenderSettings.ambientGroundColor);
        dimensionSettings.ambientIntensity = RenderSettings.ambientIntensity;
        dimensionSettings.ambientLight = CopyColor(RenderSettings.ambientLight);
        dimensionSettings.ambientMode = RenderSettings.ambientMode;
        dimensionSettings.ambientProbe = RenderSettings.ambientProbe;
        dimensionSettings.ambientSkyboxAmount = RenderSettings.ambientIntensity;
        dimensionSettings.ambientSkyColor = CopyColor(RenderSettings.ambientSkyColor);
        //dimensionSettings.customReflection = RenderSettings.customReflection; // deprecated lmao
        dimensionSettings.customReflectionTexture = RenderSettings.customReflectionTexture;
        dimensionSettings.defaultReflectionMode = RenderSettings.defaultReflectionMode;
        dimensionSettings.defaultReflectionResolution = RenderSettings.defaultReflectionResolution;
        dimensionSettings.flareFadeSpeed = RenderSettings.flareFadeSpeed;
        dimensionSettings.flareStrength = RenderSettings.flareStrength;
        dimensionSettings.fog = RenderSettings.fog;
        dimensionSettings.fogColor = CopyColor(RenderSettings.fogColor);
        dimensionSettings.fogDensity = RenderSettings.fogDensity;
        dimensionSettings.fogEndDistance = RenderSettings.fogEndDistance;
        dimensionSettings.fogMode = RenderSettings.fogMode;
        dimensionSettings.fogStartDistance = RenderSettings.fogStartDistance;
        dimensionSettings.haloStrength = RenderSettings.haloStrength;
        dimensionSettings.reflectionBounces = RenderSettings.reflectionBounces;
        dimensionSettings.reflectionIntensity = RenderSettings.reflectionIntensity;
        //dimensionSettings.skybox = RenderSettings.skybox;
        if (RenderSettings.skybox != null)
            dimensionSettings.skyboxName = RenderSettings.skybox.name;
        dimensionSettings.subtractiveShadowColor = CopyColor(RenderSettings.subtractiveShadowColor);
        if (RenderSettings.sun != null)
            dimensionSettings.sunName = RenderSettings.sun.name;
        //dimensionSettings.sun = RenderSettings.sun;
        return dimensionSettings;
    }
}
