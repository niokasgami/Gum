# Texture Address

## Introduction

The texture address property controls the texture address behavior of a sprite. Specifically it can control whether texture addresses variables are available, and how texture coordinates and sprite size are related.

## Entire Texture

If the texture address property is set to **EntireTexture** then the sprite draws its full image. The sprite does not repeat or render only part of the texture.  This renders the entire image.

![Sprite with Texture Address set to EntireTexture](<../../../.gitbook/assets/gum_texture_address_entire_texture (1).png>)

## Custom

If the texture address property is set to **Custom** then the top, bottom, left, and right properties can be independently set. This allows a sprite to only render a portion of its source texture.

![Sprite with Texture Address set to Custom](<../../../.gitbook/assets/26_19 46 21.png>)

Typically a Texture Address of Custom is used in combination with a **Width Units** of **Percent of File Width** and a **Height Units** of **Percent of File Height**. In this case, the size of the sprite depends on the texture coordinates.

When using Custom Texture Address, wrapping is possible. For more information see the [Wrap](texture-address.md#wrap) page.

## DimensionsBased

If the **Texture Address** property is set to **DimensionsBased** then the texture coordinates adjusts internally according to the width and the height of the Sprite. In other words, making the sprite larger or smaller does not stretch the image that it is rendering. Instead the image is be clipped, or clamped/wrapped according to the Wrap property.

<figure><img src="../../../.gitbook/assets/26_19 50 05.gif" alt=""><figcaption><p>Resizing a Sprite with Texture Address set to DimensionsBased</p></figcaption></figure>

When the Texture Address is set to DimensionsBased, then the Texture Width and Texture Height values are replaced by Texture Width Scale and Texture Height Scale. In this mode, the Texture Width and Texture Height values are calculated by multiplying the absolute size of the Sprite by its respective scale values.

When using DimensionsBased Texture Address, wrapping is possible. For more information see the [Wrap](texture-address.md#wrap) page.

#### DimensionsBased Texture Address and Percentage of File Width/Height

If a Sprite uses a **Width Units** of **Percentage of File Width** or a **Height Units** of **Percentage of File Height**, then the Width and Height values represent the size of the sprite relative to the entire source file.&#x20;

For example, if a Sprite is displaying a source PNG file with a width of 130 pixels and its Width is 300, then the absolute width of the Sprite is 390 (130 \* 300%). If Wrap is checked, then this indicates the number of times that the image repeats on the Sprite.

<figure><img src="../../../.gitbook/assets/image (148).png" alt=""><figcaption><p>Sprite displaying a PNG with dimensions 130x180 with a Width of 300 and Height of 200</p></figcaption></figure>

#### Texture Width Scale and Texture Height Scale

The Texture Width Scale and Texture Height Scale values determine the size of the texture on the Sprite when using DimensionsBased Texture Address. By default this value is 1, which means that the source image displays at its native size.

Increasing this value results in the image displaying larger. For example setting a value of 2 results in the displayed image being twice as large. Scale values for width and height can be set independently.

<figure><img src="../../../.gitbook/assets/22_09 35 32.gif" alt=""><figcaption><p>Larger scale values increase the displayed size of the texture</p></figcaption></figure>

{% hint style="info" %}
Since a larger value results in the image appearing larger, this means that mathematically a larger scale value results in smaller Texture Width and Texture Height value.
{% endhint %}
