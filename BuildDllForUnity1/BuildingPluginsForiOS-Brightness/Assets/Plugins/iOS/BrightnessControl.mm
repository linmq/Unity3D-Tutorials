#import "BrightnessControl.h"

@implementation BrightnessControl

+(void)setBrightness:(CGFloat) value
{
    [[UIScreen mainScreen] setBrightness:value];
}

@end

void setBrightness(float value)
{
    [BrightnessControl setBrightness:value];
}
